using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using System.Security.Claims;
using MovieShopMVC.Services;
using Microsoft.AspNetCore.Authorization;

namespace MovieShopMVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly ICurrentUser _currentUser;

        public UserController(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        [HttpGet]
        
        public async Task<IActionResult> Purchases()
        {
            // Method needs to verify whether  user is logged in
            {
                var userId = _currentUser.UserId;
            }
            //get the user id to verify
            //send the user id to the database to get al the movies the user purchased.
            // user cookie based authentication

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            var userId = _currentUser.UserId;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Reviews()
        {
            var userId = _currentUser.UserId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BuyMovies()
        {
            var userId = _currentUser.UserId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FavoriteMovie()
        {
            var userId = _currentUser.UserId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReviewMovie()
        {
            var userId = _currentUser.UserId;
            return View();
        }
    }
}
