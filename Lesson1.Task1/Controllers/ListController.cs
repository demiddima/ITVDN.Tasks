using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Task1.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
