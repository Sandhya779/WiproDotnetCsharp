namespace JWTAuthJWTBearerWebApi.Models
{
    public class UserModel
    {
        public int EmployeeId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string UserMessage { get; set; } = "Login status";
        public string AccessToken { get; set; } = "space for token";
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
