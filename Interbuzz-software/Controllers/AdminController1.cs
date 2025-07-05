using Interbuzz_software.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interbuzz_software.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dashboard() => View();

        // POST: Admin/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Email == "admin@gmail.com" && model.Password == "admin")
            {
                ViewBag.Message = "Login success";
            }
            else
            {
                ViewBag.Message = "Login failed";
            }

            return View();
        }
    }
}
