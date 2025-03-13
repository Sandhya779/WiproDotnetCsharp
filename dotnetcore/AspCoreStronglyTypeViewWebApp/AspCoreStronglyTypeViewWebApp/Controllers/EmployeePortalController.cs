using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspCoreStronglyTypeViewWebApp.Models;

namespace AspCoreStronglyTypeViewWebApp.Controllers
{
    public class EmployeePortalController : Controller
    {
        // GET: EmployeePortalController

        List<Employee> Employees = new List<Employee>()
        {
            new Employee(){EmpCode=1001,EmpName="sandhya",
                         EmpDesig="Trainer",EmpDept="training"},
            new Employee(){EmpCode=1002,EmpName="sagar",
                         EmpDesig="developer",EmpDept="r,d"},
            new Employee(){EmpCode=1003,EmpName="sushma",
                         EmpDesig="tester",EmpDept="testing"}
        };
        public ActionResult Index()
        {
            return View(Employees);
        }

        // GET: EmployeePortalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeePortalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeePortalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var maxEmployeeId = employees.Select(e => e.EmpId).DefaultIfEmpty(0).Max();
                if (maxEmployeeId == 0)
                {
                    employee.EmpId = 1001;

                }
                else
                {
                    employee.EmpId = maxEmployeeId + 1;
                }
                employees.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeePortalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeePortalController/Edit/5
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

        // GET: EmployeePortalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeePortalController/Delete/5
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
