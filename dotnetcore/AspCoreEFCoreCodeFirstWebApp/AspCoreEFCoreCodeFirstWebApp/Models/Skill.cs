using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspCoreEFCoreCodeFirstWebApp.Models
{
    public class Skill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Skill Id")]
        public int SkillId { get; set; }

        [Required]
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [Required]
        [DisplayName("IT Role Id")]
        [ForeignKey("ITRoleId")]
        public int ITRoleId { get; set; }
        [Required]
        [DisplayName("Skill Name")]
        public string SkillName { get; set; }
        [Required]
        [DisplayName("Experience Years")]
        public int ExperienceYears { get; set; }

        // PARENT TABLE NAME : IT ROLE
        public virtual ITRole ITRole { get; set; }
        //  PARENT TABLE NAME : EMPLOYEE
        public virtual Employee Employee { get; set; }
    }
}
