using BeautyHouseAM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautyHouseAM.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {

            var entity = new RegisterViewModel();
            return View(entity);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var entity = new LoginViewModel();
            return View(entity);
        }
    }
}
