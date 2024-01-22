using Lesson3Task1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson3Task1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ProductRepo repo = new ProductRepo();
       
            return View(repo);
        }
    }
}
