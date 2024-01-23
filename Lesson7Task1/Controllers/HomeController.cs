using Lesson7Task1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson7Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProductBindingModel model)
        {
            Debug.WriteLine($"Название товара: {model.NameProduct}") ;
            Debug.WriteLine($"Описание товара: {model.DescriptionProduct}");
            Debug.WriteLine($"Название товара: {model.Count}");

            return View();
        }
    }
}
