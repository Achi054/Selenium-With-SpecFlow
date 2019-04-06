using System;
using System.Collections.Generic;

namespace ShoppingKart
{
    public class Basket
    {
        public Basket()
        {
            Items = new List<Product>();
        }
        public ICollection<Product> Items { get; set; }

        public void Add(Product product)
        {
            Items.Add(product);
        }

        public void Remove(Product item)
        {
            Items?.Remove(item);
        }
    }
}
