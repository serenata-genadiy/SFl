using SerenataFlowers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SerenataFlowers.Controllers
{
    public class CartController : ApiController
    {
        private static Cart _cart;
        private Cart cart {
            get{
                if (_cart == null)
                    _cart = new Cart();
                return _cart;
            }
        }

        //// GET api/<controller>
        //public IEnumerable<Product> GetDB()
        //{
            
        //}

        // GET api/<controller>/5
        public IEnumerable<Product> Get(int idCart)
        {
            return cart.get();
        }

        public HttpResponseMessage Post([FromBody] Product p)
        {
            try
            {
                cart.add(p);

                return Request.CreateResponse(HttpStatusCode.Created, cart.get());

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int idCart , Product p)
        {
            try
            {
                cart.add(new Product { id = p.id });

                return Request.CreateResponse(HttpStatusCode.OK, p);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int i )
        {
            try
            {
                cart.remove(i);

                return Request.CreateResponse(HttpStatusCode.OK, cart.get());

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/cart/clear")]
        public void Clear()
        {
            _cart = new Cart(); 

        }
    }
}