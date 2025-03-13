using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using AspcoreStronglyTypeView.Models;

namespace AspCoreStronglyTypeView.Controllers
{
    public class EmployeePortalController : Controller
    {
        // GET: EmployeePortalController

        static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){EmpId=1001,EmpName="sandhya",
                         EmpDesg="Trainer",EmpDept="training"},
            new Employee(){EmpId=1002,EmpName="sagar",
                         EmpDesg="developer",EmpDept="r,d"},
            new Employee(){EmpId=1003,EmpName="sushma",
                         EmpDesg="tester",EmpDept="testing"}
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
                var maxEmployeeId = Employees.Select(e => e.EmpId).DefaultIfEmpty(0).Max();
                if (maxEmployeeId == 0)
                {
                    employee.EmpId = 1001;

                }
                else
                {
                    employee.EmpId = maxEmployeeId + 1;
                }
                Employees.Add(employee);
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
            Employee? employee=Employees.FirstOrDefault(e=>e.EmpId==id);
            return View(employee);
        }

        // POST: EmployeePortalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                Employee? updateEmployee = Employees.FirstOrDefault(e => e.EmpId == id);
                updateEmployee.EmpName = employee.EmpName;
                updateEmployee.EmpDesg = employee.EmpDesg;
                updateEmployee.EmpDept = employee.EmpDept;
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
            Employee? employee = Employees.FirstOrDefault(e => e.EmpId == id);
            return View(employee);
        }

        // POST: EmployeePortalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Employee? deleteEmployee = Employees.FirstOrDefault(e=>e.EmpId == id);
                Employees.Remove(deleteEmployee);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
