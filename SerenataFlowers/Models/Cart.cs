using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerenataFlowers.Models
{
    public class Cart
    {
        public string idCart { get; set; }
        private List<Product> products = new List<Product>();

        public List<Product> getDB()
        {
            List<Product> AllElements = new List<Product>  {

                new Product { id = 1 , name = "Autumn Fair", price = 19.99M, quantity = 1 },
                new Product { id = 2 , name = "Twilight", price = 12.99M, quantity = 1 },
                new Product { id = 3 , name = "Bella", price = 29.99M, quantity = 1 }

            };
            return AllElements;
        }     

        public List<Product> get()
        {
            return products;
        }

        public Cart()
        {
            Random r = new Random();
            idCart = "C" + r.Next(1, 1000);
        }

        public Product getById(int p_id)
        {
            return products.FirstOrDefault(x => x.id == p_id);
        }

        public bool add(Product p)
        {
            Product prod = getById(p.id);
            if (prod == null)
            {
                p = getDB().FirstOrDefault(x => x.id == p.id);
                if (p == null)
                {
                    return false;
                }
                p.quantity = 1;
                products.Add(p);
                return true;
            }

            prod.quantity++;

            return true;
        }

        public bool remove(int p_id)
        {
            Product prod = getById(p_id);
            if (prod == null)
            {
                return false;
            }

            prod.quantity--;

            if (prod.quantity <= 0)
            {
                return products.Remove(prod);
            }
            return true;
        }
    }

   
}