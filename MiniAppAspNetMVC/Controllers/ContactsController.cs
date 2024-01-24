using Microsoft.AspNetCore.Mvc;
using MiniAppAspNetMVC.Context;
using MiniAppAspNetMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiniAppAspNetMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contact()
        {
            using (DbUser db = new DbUser())
            {
                List<UserRegistration> list = db.InfoUsers.ToList();
                return View(list);
            }

        }
    }
}
