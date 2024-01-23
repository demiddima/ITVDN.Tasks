using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson9Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<string> { "red", "green", "blue" };

            return View(model);
        }
    }
}
