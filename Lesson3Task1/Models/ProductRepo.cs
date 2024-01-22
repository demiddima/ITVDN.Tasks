using System.Collections.Generic;

namespace Lesson3Task1.Models
{
    public class ProductRepo
    {
        public List<Product> collection { get; set; }

        public ProductRepo()
        {
            collection = new List<Product>() 
            { 
                new Product { Id = 1, Name = "Name 1", Price = 10},
                new Product { Id = 2, Name = "Name 2", Price = 20},
                new Product { Id = 3, Name = "Name 3", Price = 30},
            };
        }
    }
}
