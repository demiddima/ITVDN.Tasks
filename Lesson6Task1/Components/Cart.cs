using Lesson6Task1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6Task1.Components
{
    public class Cart : ViewComponent
    {
        public ProductRepo productRepo;


        public Cart(ProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        public IViewComponentResult Invoke()
        {
            return View(productRepo);
        }

        
    }
}
