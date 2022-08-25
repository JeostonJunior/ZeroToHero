using System.Globalization;
using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is the value of the dollar price?");
            double dolarPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"How many dollars are you going to buy?");
            double amountToBuy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalPrice = CurrencyConverter.Convert(dolarPrice, amountToBuy);
            Console.WriteLine($"Amount to be paid in reais = {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}