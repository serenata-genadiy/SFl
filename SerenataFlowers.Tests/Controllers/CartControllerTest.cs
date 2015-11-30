using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerenataFlowers.Controllers;
using SerenataFlowers.Models;


namespace SerenataFlowers.Tests.Controllers
{
    [TestClass]
    public class CartControllerTest 
    {
        [TestMethod]
        public void GetController()
        {
            CartController c = new CartController();

            var r = c.Get(0);

            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void PostController()
        {
            CartController c = new CartController();

            var r = c.Post(new Product() { id = 1 , name = "prueba1" } );

            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void PutController()
        {
            CartController c = new CartController();

            var r = c.Put(1, new Product() { id = 1, name = "prueba1" });

            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void DeleteController()
        {
            CartController c = new CartController();

            var r = c.Delete(1);

            Assert.IsNotNull(r);
        }
    }
}
