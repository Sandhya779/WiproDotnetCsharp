using AspDotNetCoreDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreDependencyInjection.Controllers
{
    public class DependencyDemoController : Controller
    {
        private readonly ICRUD _CRUD;
        public DependencyDemoController(ICRUD CRUD)
        {
            _CRUD = CRUD;
        }
        public IActionResult Index()
        {
            return View(_CRUD.GetAllEmployee());
        }
        public IActionResult Create() 
        { 
            return View();
        }
        public IActionResult Create(Employee employee)
        {
            _CRUD.Create(employee);
            return View();
        }

    }
}
