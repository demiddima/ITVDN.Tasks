using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
