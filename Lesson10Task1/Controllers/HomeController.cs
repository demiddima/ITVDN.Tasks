using Lesson10Task1.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10Task1.Controllers
{
    public class HomeController : Controller
    {
        [Log]
        public IActionResult Index()
        {
            return View();
        }

    }
}
