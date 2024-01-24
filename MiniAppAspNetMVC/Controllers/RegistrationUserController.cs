using Microsoft.AspNetCore.Mvc;
using MiniAppAspNetMVC.Context;
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
            using (DbUser db = new DbUser())
            {
                if (ModelState.IsValid)
                {
                    if (user != null && user.isAgree != false)
                    {
                        db.InfoUsers.Add(user);
                        db.SaveChanges();
                        return View("Accept", user);
                    }
                    else
                    { 
                        return NotFound();
                    }
                }
                else
                {
                    return View(user);
                }

            }



        }

        public IActionResult Accept()
        {
            return View();
        }
    }
}
