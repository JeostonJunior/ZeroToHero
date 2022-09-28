
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Products
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Enter the number of products: ");
            int productNumber = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 0; i < productNumber; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                switch (typeProduct)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string commonName = Console.ReadLine();
                        Console.Write("Price: ");
                        double commonPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product commonProduct = new Product(commonName, commonPrice);
                        products.Add(commonProduct);
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        string usedName = Console.ReadLine();
                        Console.Write("Price: ");
                        double usedPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product usedProduct = new UsedProduct(usedName, usedPrice, manufactureDate);
                        products.Add(usedProduct);
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        string importedName = Console.ReadLine();
                        Console.Write("Price: ");
                        double importedPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product importedProduct = new ImportedProduct(importedName, importedPrice, customsFee);
                        products.Add(importedProduct);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            Console.WriteLine("\n PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
