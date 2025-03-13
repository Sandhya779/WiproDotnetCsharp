using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspCoreCookiesDemoWebApp.Controllers
{
    public class CookiesConceptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //ADDING A COOKIE
        public IActionResult SetCookies()
        {
            // Name of the cookie and the value
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),// Set expiration date 
                HttpOnly = true, // Accessible only via HTTP requests 
                Secure = true, // only transmitted over HTTP
                IsEssential = true // Essential for (GDPR) compliance
                //https://gdpr-info.eu/

            };
            Response.Cookies.Append("MyCookie", "This is my cookie", cookieOptions);

            return Content("Cookie has been set");


        }
        //READING A COOKIE
        public IActionResult GetCookies()
        {
            if (Request.Cookies.TryGetValue("MyCookie", out string cookieValue))
            {
                return Content($"Cookie Value {cookieValue}");
            }
            else
            {
                return Content("Cookie not found");

            }

        }

        //DELETE A COOKIE
        public IActionResult DeleteCookies()
        {
            Response.Cookies.Delete("MyCookie");
            return Content("Cookie has been deleted");
        }
        //WORKING WITH COMPLEX DATA {JSON} IN COOKIES

        public IActionResult SetComplexCookie()
        {
            // ANONYMOUS TYPE C# 3.0 WAY
            var user = new { Name = "Abhishek Sharma", Email = "abhi@yahoo.com", Password = "abhi@123" };
            //Serialize the object to json
            var userjson = JsonConvert.SerializeObject(user);
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),// Set expiration date 
                HttpOnly = true, // Accessible only via HTTP requests 
                Secure = true, // only transmitted over HTTP
                IsEssential = true // Essential for (GDPR) compliance

            };
            Response.Cookies.Append("UserCookie", userjson, cookieOptions);
            return Content("Complex Cookie has been set");

        }
        //READING A COOKIE
        public IActionResult GetComplexCookies()
        {
            if (Request.Cookies.TryGetValue("UserCookie", out string userjson))
            {
                var user = JsonConvert.DeserializeObject<dynamic>(userjson);
                return Content($"Cookie Value {user.Name} {user.Email}");
            }
            else
            {
                return Content(" complex Cookie not found");

            }

        }

    }
}
