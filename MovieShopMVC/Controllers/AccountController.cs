using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MovieShopMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> Register(RegisterModel model)
        {
            // save the password and account info with salt
            if(ModelState.IsValid)
            {
                var user = await _accountService.CreateUser(model);
                return RedirectToAction("Login");
            }
            return View(model);
        }
        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var userLogedIn = await _accountService.ValidateUser(model.Email, model.Password);
            if (userLogedIn != null)
            {
                // Create an authentication cookie and store some claims information about the user in the cookie
                //    Claims are user related information that identifies the user (like Drivers Licence)

                // Steps to Create a Cookie
                // 1. Create claims object to store user claims information.
                var claims = new List<Claim>
                {
                    new Claim(  ClaimTypes.Email, userLogedIn.Email),
                    new Claim(  ClaimTypes.NameIdentifier, userLogedIn.Id.ToString()),
                    new Claim(  ClaimTypes.GivenName, userLogedIn.FirstName),
                    new Claim(  ClaimTypes.Surname, userLogedIn.LastName),
                    new Claim(  ClaimTypes.DateOfBirth, userLogedIn.DateOfBirth.ToShortDateString()),
                    new Claim(  "FullName", userLogedIn.FirstName +","+userLogedIn.LastName),
                    new Claim(  "Language", "en")

            };
                //2. Identity Object posts claims 
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //3. Create the Cookie using SignInAsync method created by Microsoft

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return LocalRedirect("~/");
            }
            else
            {
                return View();
            }
        }
    }
}
