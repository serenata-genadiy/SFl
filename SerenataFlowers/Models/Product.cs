using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerenataFlowers.Models
{
    public class Product
    {
        public int id { set; get; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

    }
}