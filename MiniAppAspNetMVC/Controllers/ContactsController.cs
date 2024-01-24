using Microsoft.AspNetCore.Mvc;

namespace MiniAppAspNetMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
