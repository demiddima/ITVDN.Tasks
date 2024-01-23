using Lesson8Task1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson8Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(new RegistrationBindingModel());
        }

        [HttpPost]
        public IActionResult Index(RegistrationBindingModel model)
        {
            return View();
        }
    }
}
