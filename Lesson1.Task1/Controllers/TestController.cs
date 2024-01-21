using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Task1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
