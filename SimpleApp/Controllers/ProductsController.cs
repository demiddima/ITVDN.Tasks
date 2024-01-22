using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Controllers
{
    public class ProductsController : Controller
    {
        private ProductReader reader;

        public ProductsController()
        {
            reader = new ProductReader();
        }

        // Products/List
        public IActionResult List(string category)
        {
            List<Product> products = reader.ReadFromFile();

            if (category == null)
            {
                return View(products);
            }

            List<Product> categoryCollection = products.Where(x => x.Category == category).ToList();

            return View(categoryCollection);
        }

        // Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                return View(product);
            }
            else
            {
                // Возврат ошибки 404
                return NotFound();
            }
        }
    }
}