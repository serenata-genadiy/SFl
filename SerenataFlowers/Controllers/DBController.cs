using SerenataFlowers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SerenataFlowers.Controllers
{
    public class DBController : ApiController
    {
        public IEnumerable<Product> Get(){
            Cart c = new Cart();
            return c.getDB();
        }
    }
}
