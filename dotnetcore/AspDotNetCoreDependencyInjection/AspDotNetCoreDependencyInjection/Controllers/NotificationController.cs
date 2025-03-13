using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreDependencyInjection.Models;

namespace AspDotNetCoreDependencyInjection.Controllers
{
     
    public class NotificationController : Controller
    {
        private IGreetingService _greetingService;
        public NotificationController( IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public IActionResult Index()
        {
            ViewData["message"] = _greetingService.Greeting("sandhya");
            return View();
        }
    }
}
