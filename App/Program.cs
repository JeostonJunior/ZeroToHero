using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product;

            product = new Products();

            product.Name = "Laranja";
            product.Price = 5;
            product.Quantity = 25;

            Console.WriteLine($"{product}");
        }
    }
}