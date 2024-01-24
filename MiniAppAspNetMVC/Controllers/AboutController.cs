using Microsoft.AspNetCore.Mvc;

namespace MiniAppAspNetMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Abouts()
        {
            return View();
        }
    }
}
