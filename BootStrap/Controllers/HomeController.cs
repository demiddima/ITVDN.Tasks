using Microsoft.AspNetCore.Mvc;

namespace BootStrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Page1()
        {
            return View();
        }


        public IActionResult Page2()
        {
            return View();
        }

    }
}
