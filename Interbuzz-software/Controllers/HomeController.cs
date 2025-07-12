using Interbuzz_software.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Interbuzz_software.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
         public static List<ServiceModel> serviceModels = new List<ServiceModel>();
        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                Services = AdminController.serviceModels,
                Projects = AdminController.projectModels,
                Blogs = AdminController.blogModels,
                Clients = AdminController.clientModels
            };
            return View(model);
        }

        public IActionResult SingleBlog(int id)
        {
            var blog = AdminController.blogModels.FirstOrDefault(b => b.Id == id);

            if (blog == null)
            {
                return NotFound(); // or return View("Error");
            }

            return View(blog); // ✅ Pass valid BlogModel
        }


        [Route("Service/SubService/{id}")]
        public IActionResult SubService(int id)
        {
            var service = AdminController.serviceModels.FirstOrDefault(s => s.Id == id);
            if (service == null)
                return NotFound();

            return View(service);
        }


        public IActionResult Service()
        {
            var model = new DashboardViewModel
            {
                Services = AdminController.serviceModels
            };
            return View(model); // Views/Home/Service.cshtml
        }

        public IActionResult Blog()
        {
            return View(AdminController.blogModels); // Pass only the list
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            var model = new DashboardViewModel
            {
                Projects = AdminController.projectModels
            };
            return View(model); // Views/Home/Projects.cshtml
        }

        public IActionResult Clients()
        {
            var model = new DashboardViewModel
            {
                Clients = AdminController.clientModels
            };
            return View(model); // Views/Home/Clients.cshtml
        }

        public IActionResult Contact() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

    }
}
