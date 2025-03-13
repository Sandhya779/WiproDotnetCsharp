using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1.Pages
{
    public class EmployeeModel : PageModel
    {
        public List<Employee> EmployeeList { get; set; }
        public EmployeeModel(List <Employee> listofEmployees)
        {
            EmployeeList = listofEmployees;
            EmployeeList.Add(new Employee() { ID = 1, FirstName = "Sandhya", LastName = "Jabbala" });
            EmployeeList.Add(new Employee() { ID = 2, FirstName = "sandhya", LastName = "jabbala" });
            EmployeeList.Add(new Employee() { ID = 3, FirstName = "sandy", LastName = "rani" });
        }
        
        [BindProperty(SupportsGet=true)]
        public int ID { get; set; }
        public void OnGet(int ID)
        {
            if(ID==0)
            {
                this.ID = 1;
            }
        }
    }
}
