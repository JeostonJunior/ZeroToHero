using System.Globalization;

namespace Product
{
    public class Products
    {
        public string Name;
        public double Price;
        public int Quantity;

        //////// Sobrecarga
        // public Products() { }
        // public Products(string name, double price, int quantity)
        // {
        //     Name = name;
        //     Price = price;
        //     Quantity = quantity;
        // }
        // public Products(string name, double price)
        // {
        //     Name = name;
        //     Price = price;
        //     Quantity = 5;
        // }
        /////// Fim da Sobrecarga

        ////// Usando this

        public Products()
        {
            Quantity = 1;
        }

        /// Esse this faz referencia ao construtor padrão da classe
        public Products(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Products(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        ////// Fim do Usando this

        public override string ToString()
        {
            return $"Product:{Name} | Price:{Price.ToString("F2", CultureInfo.InvariantCulture)} | Quantity:{Quantity} | Amount:{Amount()}";
        }
        public double Amount()
        {
            double amount;
            amount = Price * Quantity;

            return amount;
        }
        public int AlterQantity()
        {
            Console.WriteLine($"Entre com a quantidade a ser adicionada:");
            int add = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return Quantity += add;
        }
        public int Remove()
        {
            Console.WriteLine($"Entre com a quantidade a ser removida:");
            int remove = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return Quantity -= remove;
        }
    }
}