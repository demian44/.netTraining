using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [HttpPost]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return this.BadRequest();
            }
            
            return this.Ok(product);
        }

        [HttpGet]
        [ActionName("Thumbnail")]
        public HttpResponseMessage GetThumbnailImage(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.Accepted);
            /* return new HttpResponseMessage(HttpStatusCode.BadRequest);
             return new HttpResponseMessage(HttpStatusCode.OK); 
             return new HttpResponseMessage(HttpStatusCode.InternalServerError); /
             return new HttpResponseMessage(HttpStatusCode.MethodNotAllowed); /*/
        }

        [HttpPost]
        [ActionName("Thumbnail")]
        public void AddThumbnailImage(int id)
        {

        }
    }
}
