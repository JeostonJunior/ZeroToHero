using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }
        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag ()
        {
            return $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
