using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo
{
    public class Cart
    {
        private List<Product> cart;


        public Cart()
        {
            cart = new List<Product>();
        }

        public List<Product> ShoppingCart { get => cart; }

        public void Add(Product product)
        {
            cart.Add(product);
        }
    }
}
