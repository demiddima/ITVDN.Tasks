using Microsoft.AspNetCore.Mvc;

namespace Lesson6Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
