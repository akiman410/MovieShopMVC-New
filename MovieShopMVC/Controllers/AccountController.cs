using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            //save the password, account Information and add salt to password
            var user = await _accountService.CreateUser(model);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var userLogin = await _accountService.ValidateUser(model.Email, model.Password);
            if (userLogin)
                // authentication cookie and store some claims information about the user
                //This is information that identifies the user
                return LocalRedirect("~/");
            else
            {
                return View();
            }
        }
    }
}
