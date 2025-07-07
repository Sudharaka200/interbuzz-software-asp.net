using Interbuzz_software.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Metadata;

namespace Interbuzz_software.Controllers
{
    public class AdminController : Controller
    {
        // ✅ Static in-memory blog storage
        public static List<BlogModel> blogposts = new List<BlogModel>();

        // GET: Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Email == "admin@gmail.com" && model.Password == "admin")
            {
                ViewBag.Message = "Login success";
                return RedirectToAction("Dashboard");
            }

            ViewBag.Message = "Login failed";
            return View();
        }

        //View Dashboard
        public IActionResult Dashboard()
        {
            return View(blogModels);
        }

        //Add Blog View
        public IActionResult CreateBlog()
        {
            return View("~/Views/Admin/Blog/CreateBlog.cshtml");
        }

        //Add sample data
        public static List<BlogModel> blogModels = new List<BlogModel>
        {
            new BlogModel{ Id = 1, Title = "Test 1", Description = "test2"}
        };

        //Create Blog
        [HttpPost]
        public IActionResult CreateBlog(BlogModel blogModel)
        {
            blogModel.Id = blogModels.Any() ? blogModels.Max(b => b.Id) + 1 : 1;

            blogModel.Date = DateOnly.FromDateTime(DateTime.Now);

            if (blogModel.BlogImage != null && blogModel.BlogImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var fileName = Path.GetFileName(blogModel.BlogImage.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    blogModel.BlogImage.CopyTo(stream);
                }

                blogModel.BlogImagePath = "/uploads/" + fileName;
            }

            blogModels.Add(blogModel); // ✅ Only once
            return RedirectToAction("Dashboard");
        }

        //Edit Using Id
        //Get edit details
        public IActionResult EditBlog(int id)
        {
            var blogModel = blogModels.FirstOrDefault(f => f.Id == id);
            return blogModel == null ? NotFound() : View("~/Views/Admin/Blog/EditBlog.cshtml", blogModel); ;
        }

        [HttpPost]
        public IActionResult EditBlog(BlogModel updated)
        {
            var blogModel = blogModels.FirstOrDefault(f => f.Id == updated.Id);
            if (blogModel == null) return NotFound();

            blogModel.Title = updated.Title;
            blogModel.Description = updated.Description;

            if (updated.BlogImage != null && updated.BlogImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var fileName = Path.GetFileName(updated.BlogImage.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.BlogImage.CopyTo(stream);
                }

                blogModel.BlogImagePath = "/uploads/" + fileName;
            }

            return RedirectToAction("Dashboard");
        }

        // GET: Delete confirmation (optional)
        public IActionResult Delete(int id)
        {
            var blogModel = blogModels.FirstOrDefault(b => b.Id == id);
            return blogModel == null
                ? NotFound()
                : View("~/Views/Admin/Blog/DeleteBlog.cshtml", blogModel); // Optional confirmation view
        }

        // POST: Actually delete the blog
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var blogModel = blogModels.FirstOrDefault(b => b.Id == id);
            if (blogModel == null) return NotFound();

            blogModels.Remove(blogModel);
            return RedirectToAction("Dashboard");
        }



    }
}
