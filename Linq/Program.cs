using System;
using System.IO;
using System.Globalization;
using Linq.Models;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"./Data/Products.csv";
            List<Products> products = new List<Products>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] pipe = sr.ReadLine().Split(',');
                        string name = pipe[0];
                        double price = double.Parse(pipe[1], CultureInfo.InvariantCulture);

                        products.Add(new Products { Name = name, Price = price });
                    }
                }
                double averagePrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine($"{averagePrice.ToString("f2")}");
                var productsLowAverage = products.Where(p => p.Price < averagePrice).OrderByDescending(p => p.Price).Select(p => p.Name);
                foreach (var item in productsLowAverage)
                {
                    Console.WriteLine($"{item}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}