namespace JWTAuthJWTBearerWebApi.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    namespace ExperiencePostWebApi.Models
    {
        //POCO CLASS
        public class Employee
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [DisplayName("Employee Id")]
            public int EmployeeId { get; set; }
            [Required]
            //[StringLength(25)]
            [DisplayName("First Name")]
            public string FirstName { get; set; }
            [Required]
            //[StringLength(25)]
            [DisplayName("Last Name")]
            public string LastName { get; set; }
            [Required]
            //[RegularExpression(@"^[0-9]{10,15}$", ErrorMessage = "It must contain digit and -")]
            [DisplayName("Cell Number")]
            public string CellNumber { get; set; }
            [Required]
            //[RegularExpression(@"^[0-9]{10,15}$", ErrorMessage = "It must contain digit and -")]
            [DisplayName("Land Line")]
            public string LandLine { get; set; }
            [Required]
            [EmailAddress]
            [DisplayName("Email Address")]
            public string EmailId { get; set; }
            [Required]
            //[RegularExpression(@"^[a-zA-Z0-9@]{7,15}$", ErrorMessage = "Password must meet requirements")]
            public string Password { get; set; }

            // CHILD TABLE NAME : SKILL
            public virtual ICollection<Skill> Skills { get; set; }


        }
    }

}
