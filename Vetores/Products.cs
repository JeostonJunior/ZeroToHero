using System;
namespace Vetores
{
    public class Products
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}