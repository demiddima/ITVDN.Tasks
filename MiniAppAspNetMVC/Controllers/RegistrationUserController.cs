using Microsoft.AspNetCore.Mvc;
using MiniAppAspNetMVC.Context;
using MiniAppAspNetMVC.Crypt;
using MiniAppAspNetMVC.Models;
using System.Linq;

namespace MiniAppAspNetMVC.Controllers
{
    public class RegistrationUserController : Controller
    {
        private CryptPass crypt;
        public RegistrationUserController()
        {
            this.crypt = new CryptPass();
        }

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
                        user.Password = crypt.Encode(user.Password);
                        user.ConfirmPassword = crypt.Encode(user.ConfirmPassword);

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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LogIn users)
        {
            if (!ModelState.IsValid)
            {
                UserRegistration user = null;
                using (DbUser db = new DbUser())
                {
                    user = db.InfoUsers.FirstOrDefault(x => x.Email == users.Email && x.Password == users.Password);

                }
                if (user != null)
                {
                    return View("AcceptLogin", user);
                }
            }
            return View();
        }
    }
}
