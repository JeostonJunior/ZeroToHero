using System.Globalization;

namespace Product
{
    public class Products
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

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