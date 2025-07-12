using Interbuzz_software.Models;
using Microsoft.AspNetCore.Mvc;


using static Ganss.Xss.HtmlSanitizer;
using AngleSharp.Css.Dom;
using Ganss.Xss;

//admin Link
//https://localhost:7252/Admin/Login
//username: admin@gmail.com
//password: admin

namespace Interbuzz_software.Controllers
{
    public class AdminController : Controller
    {
        // ✅ Static in-memory blog storage
        //public static List<BlogModel> blogposts = new List<BlogModel>();

        //public static List<ServiceModel> serviceModels = new List<ServiceModel>();

        //public static List<ProjectModel> projectModels = new List<ProjectModel>();

        //public static List<ClientModel> clientModels = new List<ClientModel>();



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
        //public IActionResult Dashboard()
        //{
        //    return View(blogModels);
        //}

        //Add Blog View
        public IActionResult CreateBlog()
        {
            return View("~/Views/Admin/Blog/CreateBlog.cshtml");
        }

        //Add sample data
        public static List<BlogModel> blogModels = new List<BlogModel>
        {
            new BlogModel{ Id = 1, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
            new BlogModel{ Id = 2, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
            new BlogModel{ Id = 3, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
            new BlogModel{ Id = 4, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
            new BlogModel{ Id = 5, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
            new BlogModel{ Id = 6, BlogImagePath = "/images/blog-img6.png", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."}
        };

        public static List<ServiceModel> serviceModels = new List<ServiceModel>
        {
            new ServiceModel{ Id = 1, ServiceTitle = "SEO", ServiceDescription = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr...", ServiceImgLogoPath = "/images/Mask group.png", ServicebgImg1Path = "/images/employee-working-marketing-setting 1.png", ServiceBgImg2Path = "/images/blog-c-2.jpg" },
            new ServiceModel{ Id = 2, ServiceTitle = "SEO", ServiceDescription = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr...", ServiceImgLogoPath = "/images/Mask group.png", ServicebgImg1Path = "/images/employee-working-marketing-setting 1.png", ServiceBgImg2Path = "/images/blog-c-2.jpg" },
            new ServiceModel{ Id = 3, ServiceTitle = "SEO", ServiceDescription = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr...", ServiceImgLogoPath = "/images/Mask group.png", ServicebgImg1Path = "/images/employee-working-marketing-setting 1.png", ServiceBgImg2Path = "/images/blog-c-2.jpg" },
            new ServiceModel{ Id = 4, ServiceTitle = "SEO", ServiceDescription = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr...", ServiceImgLogoPath = "/images/Mask group.png", ServicebgImg1Path = "/images/employee-working-marketing-setting 1.png", ServiceBgImg2Path = "/images/blog-c-2.jpg" }
        };

        public static List<ProjectModel> projectModels = new List<ProjectModel>
        {
            new ProjectModel{ Id = 1, ProjectTitle = "Social Media Marketing1", ProjectDescription = "Innovative Branding Initiative", ProjectImgPath = "/images/1Group 20.png" },
            new ProjectModel{ Id = 2, ProjectTitle = "Social Media Marketing1", ProjectDescription = "Innovative Branding Initiative", ProjectImgPath = "/images/Group 20.png" },
            new ProjectModel{ Id = 3, ProjectTitle = "Social Media Marketing1", ProjectDescription = "Innovative Branding Initiative", ProjectImgPath = "/images/Group 201.png" },
            new ProjectModel{ Id = 3, ProjectTitle = "Social Media Marketing1", ProjectDescription = "Innovative Branding Initiative", ProjectImgPath = "/images/1Group 201.png" }
        };

        public static List<ClientModel> clientModels = new List<ClientModel>
        {
            new ClientModel{ Id = 1, ClientName = "John Doe", ClinetJob = "CEO, TechCorp", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" },
            new ClientModel{ Id = 2, ClientName = "Jane Smith", ClinetJob = "Marketing Head, MarketX", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" },
            new ClientModel{ Id = 3, ClientName = "Mike Johnson", ClinetJob = "Manager, BuildIt", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" },
            new ClientModel{ Id = 4, ClientName = "John Doe", ClinetJob = "CEO, TechCorp", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" },
            new ClientModel{ Id = 5, ClientName = "Jane Smith", ClinetJob = "Marketing Head, MarketX", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" },
            new ClientModel{ Id = 6, ClientName = "Mike Johnson", ClinetJob = "Manager, BuildIt", ClientComment = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor Lorem ipsum dolorsit Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor", ClientProfilePath = "/images/image-profile.png" }
        };



        //Blog
        //Create Blog
        [HttpPost]
        [ValidateAntiForgeryToken]
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

            blogModels.Add(blogModel);
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




        //Service
        public IActionResult Dashboard()
        {
            var model = new DashboardViewModel
            {
                Blogs = blogModels,       
                Services = serviceModels,  
                Projects = projectModels,
                Clients = clientModels
            };

            return View(model);
        }


        public IActionResult CreateService()
        {
            return View("~/Views/Admin/Services/CreateService.cshtml");
        }

        [HttpPost]
        public IActionResult CreateService(ServiceModel serviceModel)
        {
            serviceModel.Id = serviceModels.Any() ? serviceModels.Max(f => f.Id) + 1 : 1;

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            // ✅ Save ServiceImgLogo
            if (serviceModel.ServiceImgLogo != null && serviceModel.ServiceImgLogo.Length > 0)
            {
                var fileName = Path.GetFileName(serviceModel.ServiceImgLogo.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    serviceModel.ServiceImgLogo.CopyTo(stream);
                }

                serviceModel.ServiceImgLogoPath = "/uploads/" + fileName;
            }

            // ✅ Save ServiceBgImg1
            if (serviceModel.ServiceBgImg1 != null && serviceModel.ServiceBgImg1.Length > 0)
            {
                var fileName = Path.GetFileName(serviceModel.ServiceBgImg1.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    serviceModel.ServiceBgImg1.CopyTo(stream);
                }

                serviceModel.ServicebgImg1Path = "/uploads/" + fileName;
            }

            // ✅ Save ServiceBgimg2
            if (serviceModel.ServiceBgimg2 != null && serviceModel.ServiceBgimg2.Length > 0)
            {
                var fileName = Path.GetFileName(serviceModel.ServiceBgimg2.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    serviceModel.ServiceBgimg2.CopyTo(stream);
                }

                serviceModel.ServiceBgImg2Path = "/uploads/" + fileName;
            }

            // ✅ Finally add to the in-memory list
            serviceModels.Add(serviceModel);

            return RedirectToAction("Dashboard");
        }


        // GET Edit Service by Id
        public IActionResult EditService(int id)
        {
            var serviceModel = serviceModels.FirstOrDefault(f => f.Id == id);
            return serviceModel == null
                ? NotFound()
                : View("~/Views/Admin/Services/EditService.cshtml", serviceModel);
        }

        // POST Edit Service
        [HttpPost]
        public IActionResult EditService(ServiceModel updated)
        {
            var serviceModel = serviceModels.FirstOrDefault(r => r.Id == updated.Id);
            if (serviceModel == null) return NotFound();

            // ✅ Update text fields
            serviceModel.ServiceTitle = updated.ServiceTitle;
            serviceModel.ServiceDescription = updated.ServiceDescription;

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            // ✅ Update Service Logo
            if (updated.ServiceImgLogo != null && updated.ServiceImgLogo.Length > 0)
            {
                var fileName = Path.GetFileName(updated.ServiceImgLogo.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.ServiceImgLogo.CopyTo(stream);
                }

                serviceModel.ServiceImgLogoPath = "/uploads/" + fileName;
            }

            // ✅ Update Service Background Image 1
            if (updated.ServiceBgImg1 != null && updated.ServiceBgImg1.Length > 0)
            {
                var fileName = Path.GetFileName(updated.ServiceBgImg1.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.ServiceBgImg1.CopyTo(stream);
                }

                serviceModel.ServicebgImg1Path = "/uploads/" + fileName;
            }

            // ✅ Update Service Background Image 2
            if (updated.ServiceBgimg2 != null && updated.ServiceBgimg2.Length > 0)
            {
                var fileName = Path.GetFileName(updated.ServiceBgimg2.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.ServiceBgimg2.CopyTo(stream);
                }

                serviceModel.ServiceBgImg2Path = "/uploads/" + fileName;
            }

            return RedirectToAction("Dashboard");
        }




        //Delete Service
        public IActionResult DeleteService(int id)
        {
            var serviceModel = serviceModels.FirstOrDefault(f => f.Id == id);
            return serviceModel == null ? NotFound() : View("~/Views/Admin/Services/DeleteService.cshtml", serviceModel);

        }
        //delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Service/ConfirmDelete")]
        public IActionResult ConfirmServiceDelete(int id)
        {
            var serviceModel = serviceModels.FirstOrDefault(f => f.Id == id);
            if (serviceModel == null) return NotFound();

            serviceModels.Remove(serviceModel);
            return RedirectToAction("Dashboard");
        }




        //Projects
        //Create Project View
        public IActionResult CreateProject()
        {
            return View("~/Views/Admin/Projects/CreateProject.cshtml");
        }

        //Create Project
        [HttpPost]
        public IActionResult CreateProject(ProjectModel projectModel)
        {
            projectModel.Id = projectModels.Any() ? projectModels.Max(f => f.Id) + 1 : 1;

            if (projectModel.ProjectImg != null && projectModel.ProjectImg.Length > 0)
            {
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                var fileExtension = Path.GetExtension(projectModel.ProjectImg.FileName);

                var safeFileName = Guid.NewGuid().ToString() + fileExtension;

                var filePath = Path.Combine(uploadFolder, safeFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    projectModel.ProjectImg.CopyTo(stream);
                }

                projectModel.ProjectImgPath = "/uploads/" + safeFileName;
            }

            projectModels.Add(projectModel);
            return RedirectToAction("Dashboard");
        }

        //Get Projects for Edit
        public IActionResult EditProject(int id)
        {
            var projectModel = projectModels.FirstOrDefault(f => f.Id == id);
            return projectModel == null
                ? NotFound()
                : View("~/Views/Admin/Projects/EditProject.cshtml", projectModel);
        }

        //Edit Project
        [HttpPost]
        public IActionResult EditProject(ProjectModel updated)
        {
            var projectModel = projectModels.FirstOrDefault(f => f.Id == updated.Id);
            if (projectModel == null) return NotFound();

            projectModel.ProjectTitle = updated.ProjectTitle;
            projectModel.ProjectDescription = updated.ProjectDescription;

            if (updated.ProjectImg != null && updated.ProjectImg.Length > 0)
            {
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                var fileName = Path.GetFileName(updated.ProjectImg.FileName);
                var filePath = Path.Combine(uploadFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.ProjectImg.CopyTo(stream);
                }

                projectModel.ProjectImgPath = "/uploads/" + fileName;
            }

            return RedirectToAction("Dashboard");

        }

        //Delete Project
        public IActionResult DeleteProject(int id)
        {
            var projectModel = projectModels.FirstOrDefault(f => f.Id == id);
            return projectModel == null ? NotFound() : View("~/Views/Admin/Projects/DeleteProject.cshtml", projectModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Projects/ConfirmProjectDelete")]
        public IActionResult ConfirmProjectDelete(int id)
        {
            var projectModel = projectModels.FirstOrDefault(f => f.Id == id);
            if (projectModel == null) return NotFound();

            projectModels.Remove(projectModel);
            return RedirectToAction("Dashboard");
        }




        //clients
        //Create Client Comment
        public IActionResult CreateClient()
        {
            return View("~/Views/Admin/Clients/CreateClient.cshtml");
        }

        //Create
        [HttpPost]
        public IActionResult Createclient(ClientModel clientModel)
        {
            clientModel.Id = clientModels.Any() ? clientModels.Max(c => c.Id) + 1 : 1;

            if (clientModel.ClientProfile != null && clientModel.ClientProfile.Length > 0)
            {
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                var fileExtention = Path.GetExtension(clientModel.ClientProfile.FileName);

                var safeFileName = Guid.NewGuid().ToString() + fileExtention;

                var filePath = Path.Combine(uploadFolder, safeFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    clientModel.ClientProfile.CopyTo(stream);
                }

                clientModel.ClientProfilePath = "/uploads/" + safeFileName;
            }

            clientModels.Add(clientModel);
            return RedirectToAction("Dashboard");

        }


        //Edit Client
        public IActionResult EditClient (int id)
        {
            var clientModel = clientModels.FirstOrDefault(f => f.Id == id);
            return clientModel == null
                ? NotFound()
                : View("~/Views/Admin/Clients/EditClient.cshtml", clientModel);
        }

        //Edit Project
        [HttpPost]
        public IActionResult EditClient(ClientModel updated)
        {
            var clientModel = clientModels.FirstOrDefault(f => f.Id == updated.Id);
            if (clientModel == null) return NotFound();

            clientModel.ClientName = updated.ClientName;
            clientModel.ClinetJob = updated.ClinetJob;
            clientModel.ClientComment = updated.ClientComment;

            if(updated.ClientProfile != null && updated.ClientProfile.Length > 0)
            {
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                var fileName = Path.GetFileName(updated.ClientProfile.FileName);
                var filePath = Path.Combine(uploadFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    updated.ClientProfile.CopyTo(stream);
                }
                clientModel.ClientProfilePath = "/uploads/" + fileName;
            }
            return RedirectToAction("Dashboard");

        }

        //Delete Client
        public IActionResult DeleteClient(int id)
        {
            var clientModel = clientModels.FirstOrDefault(f => f.Id == id);
            return clientModel == null ? NotFound() : View("~/Views/Admin/Clients/DeleteClients.cshtml", clientModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Clients/ConfirmClientsDelete")]
        public IActionResult ConfirmClientsDelete(int id)
        {
            var clientModel = clientModels.FirstOrDefault(f => f.Id == id);
            if (clientModel == null) return NotFound();

            clientModels.Remove(clientModel);
            return RedirectToAction("dashboard");
        }








    }
}
