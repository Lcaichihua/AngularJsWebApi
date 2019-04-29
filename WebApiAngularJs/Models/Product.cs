using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAngularJs.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name{get; set; }
        public decimal Price{get; set; }
        public int Quantity { get; set; }
        

    }
}