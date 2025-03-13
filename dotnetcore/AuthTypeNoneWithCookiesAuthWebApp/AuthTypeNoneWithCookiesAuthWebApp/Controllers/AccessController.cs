using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using AuthTypeNoneWithCookiesAuthWebApp.Models;
using Microsoft.AspNetCore.Authentication;
namespace AuthTypeNoneWithCookiesAuthWebApp.Controllers
{
    public class AccessController : Controller
    {
        // GET: AccessController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            //the person who have logged in 
            ClaimsPrincipal claimsUser = HttpContext.User;
            if (claimsUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();

        } 

        // POST: AccessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLogin modelLogin)
        {
            if (modelLogin.Email == "user@example.com" && modelLogin.Password == "user@123")
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,modelLogin.Email)

                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {

                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn,
                    ExpiresUtc = DateTimeOffset.Now.AddDays(1)



                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewData["ValidateMessage"] = "User not found";
                return View();
            }
        }

    }
}
