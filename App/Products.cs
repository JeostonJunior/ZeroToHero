using System.Globalization;

namespace MyApp
{
    public class Products
    {
        public string Name;
        public double Price;
        public int Quantity;

        public void ProductsData()
        {
            Console.WriteLine($"Product:{Name} | Price:{Price} | Quantity:{Quantity} | Amount:{Amount()}");
        }
        public override string ToString()
        {
            return $"Product:{Name} | Price:{Price} | Quantity:{Quantity} | Amount:{Amount()}";
        }
        public double Amount()
        {
            double amount;
            amount = Price * Quantity;

            return amount;
        }
        public void AlterQantity()
        {
            Console.WriteLine($"Entre com a quantidade a ser adicionada:");
            int add = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Quantity += add;

            ProductsData();
        }
        public void Remove()
        {
            Console.WriteLine($"Entre com a quantidade a ser removida:");
            int remove = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Quantity -= remove;

            ProductsData();
        }
    }
}