using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspcoredemoWebApp1.Controllers
{
    public class Customer
    {
        public int CustomerCode { get; set; }
        public string CustomerName{ get; set; }
    }

    public class Employee
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesig { get; set; }
        public string EmployeeDept { get; set; }
    }
    public class Controller1 : Controller
    {
        // GET: Controller1
        public ActionResult Index()
        {
            //action to view
            ViewData["data"] = "This is my information";

            Customer customer = new Customer
            {
                CustomerCode = 123,
                CustomerName = "sandhya"
            };
            ViewBag.CustomerCode= customer.CustomerCode; 
            ViewBag.CustomerName= customer.CustomerName; 

            return View();
        }

        // GET: Controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmployeeCode = Convert.ToInt32(Request.Form["EmployeeCode"]),
                    EmployeeName = Request.Form["EmployeeName"],
                    EmployeeDesig = Request.Form["EmployeeDesig"],
                    EmployeeDept = Request.Form ["EmployeeDept"]
                };
                
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("ShowData",employee);
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult ShowData(Employee employee)
        {
            ViewBag.employee = employee;
            return View();
        }
        public ActionResult EmployeeRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeRegistration(Employee employee)
        {
            return RedirectToAction("ShowData", employee);
        }
        // GET: Controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controller1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controller1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
