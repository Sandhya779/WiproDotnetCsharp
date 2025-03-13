using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspCoreEFCoreCodeFirstWebApp.Models
{
    //POCO-
    public class Employee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [DisplayName("Employee ID")]
        [Required(ErrorMessage ="Enter valid Employee id")]
        public int EmployeeID { get; set; }
        
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Enter valid first name")]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Enter valid last name")]
        public string LastName { get; set; }
        
        [DisplayName("Cell Number")]
        [Required(ErrorMessage = "Enter valid cell number")]
        public string CellNumber { get; set; }
        
        [DisplayName("Land line")]
        [Required(ErrorMessage = "Enter valid landline")]
        public string LandLine { get; set; }
       
        [DisplayName("Email id")]
        [Required(ErrorMessage = "Enter valid email id")]
        public string EmailID { get; set; }
        
        [DisplayName("Password")]
        [Required(ErrorMessage = "Enter valid password")]
        [PasswordPropertyText]
        public string Password { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
