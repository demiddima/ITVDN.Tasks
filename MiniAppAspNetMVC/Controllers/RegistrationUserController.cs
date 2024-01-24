using Microsoft.AspNetCore.Mvc;
using MiniAppAspNetMVC.Models;

namespace MiniAppAspNetMVC.Controllers
{
    public class RegistrationUserController : Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(UserRegistration user)
        {
            if(user != null && user.isAgree != false)
            {
                //add db
                return View("Accept", user);
            }
            else
            {
                return NotFound();
            }
           
        }

        public IActionResult Accept()
        {
            return View();
        }
    }
}
