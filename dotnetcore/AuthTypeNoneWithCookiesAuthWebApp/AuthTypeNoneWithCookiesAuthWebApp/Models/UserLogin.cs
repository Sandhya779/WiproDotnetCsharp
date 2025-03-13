using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AuthTypeNoneWithCookiesAuthWebApp.Models
{
    public class UserLogin
    {
        [Required]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
        [DisplayName("Keep Logged In")]
        public bool KeepLoggedIn { get; set; }
    }
}
