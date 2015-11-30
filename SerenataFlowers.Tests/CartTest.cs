using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerenataFlowers.Models;
using System.Collections.Generic;
using System.Linq;

namespace SerenataFlowers.Tests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void getDB()
        {
            Cart c = new Cart();

            List<Product> products = c.getDB();

            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void add()
        {
            Cart c = new Cart();

            Product p = new Product() { id = 1  , name = "prueba1" };
            
            Assert.IsTrue(c.add(p));
            Assert.IsNotNull(c.getById(p.id));

        }

        [TestMethod]
        //[ExpectedException(typeof(System.Exception))]
        public void add_empty()
        {
            Cart c = new Cart();

            Product p = new Product();

            bool result = c.add(p);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void getById()
        {
            Cart c = new Cart();

            Product p = new Product() { id = 1, name = "prueba1" };
            c.add(p);

            Assert.AreEqual(c.getById(1).id , p.id);
        }

        [TestMethod]        
        public void getById_null()
        {
            Cart c = new Cart();

            Assert.IsNull(c.getById(0));
        }

        [TestMethod]
        public void get()
        {
            Cart c = new Cart();

            Product p = new Product() { id = 1, name = "prueba1" };
            c.add(p);

            Product q = c.get().First();

            Assert.AreEqual(q.id, p.id);
        }

        [TestMethod]
        public void remove_complete()
        {
            Cart c = new Cart();

            Product p = new Product() { id = 1, name = "prueba1" };
            c.add(p);

            Assert.IsTrue(c.remove(p.id));
            Assert.IsNull(c.getById(p.id));
        }

        [TestMethod]
        public void remove_1()
        {
            Cart c = new Cart();

            Product p = new Product() { id = 1, name = "prueba1" };
            c.add(p);
            c.add(p);

            Assert.IsTrue(c.remove(p.id));
            Assert.AreEqual(c.getById(p.id).quantity , 1);
        }

        [TestMethod]
        public void remove_empty()
        {
            Cart c = new Cart();
                        
            Assert.IsFalse(c.remove(0));
            Assert.IsNull(c.getById(0));
        }
    }
}
