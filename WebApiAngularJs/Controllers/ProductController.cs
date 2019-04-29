using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAngularJs.Models;

namespace WebApiAngularJs.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            ProductModel pm = new ProductModel();
            return pm.findAll().AsEnumerable();
           
        }

        // GET: api/Product/5
        public Product Get(string id)
        {
            ProductModel pm = new ProductModel();
            return pm.find(id);
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
