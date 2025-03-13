using System.Diagnostics;
using AspDotNetCoreDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGreetingService _greetingService;



        public HomeController(ILogger<HomeController> logger,IGreetingService greetingService)
        {
            _logger = logger;
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "sandhya";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
