using Microsoft.AspNetCore.Mvc;

namespace MiniAppAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
