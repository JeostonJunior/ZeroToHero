using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class ImportedProduct: Product
    {    
        public double CustomsFee { get; protected set; }
        public ImportedProduct (string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag ()
        {
            return $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
        public double TotalPrice ()
        {
            return Price += CustomsFee;
        }

    }
}
