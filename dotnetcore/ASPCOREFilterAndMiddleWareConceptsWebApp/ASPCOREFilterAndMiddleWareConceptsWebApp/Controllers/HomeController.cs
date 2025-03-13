using System.Diagnostics;
using ASPCOREFilterAndMiddleWareConceptsWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCOREFilterAndMiddleWareConceptsWebApp.Controllers
{
    //[ServiceExceptionInterceptor]
    [ServiceFilter(typeof(CustomAsyncActionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //int x = 10, y = 0, result = 0;
            //result = x / y;
            return View();
            //try
            //{
                
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(new { error = ex.Message });
            //    //return Content(ex.Message);
            //}   
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
