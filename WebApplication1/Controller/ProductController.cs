using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    public class ProductController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product {Id= 1, Name = "Product1" , Category = "Category 1", Price = 1  },
            new Product {Id= 1, Name = "Product2" , Category = "Category 2", Price = 3.75M },
            new Product {Id= 1, Name = "Product3" , Category = "Category 3", Price = 16.99M  }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GeProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}