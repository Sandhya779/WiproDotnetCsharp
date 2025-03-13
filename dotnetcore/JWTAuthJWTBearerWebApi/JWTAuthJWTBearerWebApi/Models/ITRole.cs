
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JWTAuthJWTBearerWebApi.Models
{
    public class ITRole
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("IT Role Id")]
        public int ITRoleId { get; set; }
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }

        //CHILD TABLE NAME : SKILL 
        public virtual ICollection<Skill> Skills { get; set; }

    }
}
