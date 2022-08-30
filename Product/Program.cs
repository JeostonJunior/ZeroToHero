using System.Globalization;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Enter the product name:");
            string productName = Console.ReadLine();

            Console.WriteLine($"Enter the product price:");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Console.WriteLine($"Enter the product quantity:");
            // int productQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Products product = new Products(productName, productPrice, productQuantity);

            Products product = new Products(productName, productPrice);

            Console.WriteLine($"{product}");

            Products productNewInicialization = new Products
            {
                Name = "Maça",
                Price = 12.00,
                Quantity = 10
            };

            Console.WriteLine($"{productNewInicialization}");

            // product.AlterQantity();
            // Console.WriteLine($"{product}");

            // product.Remove();
            // Console.WriteLine($"{product}");
        }
    }
}