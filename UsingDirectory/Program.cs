using System;
using System.Globalization;
using System.IO;
using UsingDirectory.Entities;

namespace UsingDirectory
{
    internal class Program
    {
        static void Main (string[] args)
        {
            try
            {
                string path = @"C:\Users\jeoston.araujo\Documents\ZeroToHero\UsingDirectory\Products.txt";
                string directoryName = Path.GetDirectoryName(path);
                string targetPath = directoryName + @"\out";
                string nameFile = targetPath + @"\summary.csv";

                Directory.CreateDirectory(targetPath);

                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = new StreamWriter(nameFile))
                {
                    foreach (string line in lines)
                    {
                        string[] field = line.Split(',');
                        string productName = field[0];
                        double productValue = double.Parse(field[1], CultureInfo.InvariantCulture);
                        int productQuantity = int.Parse(field[2]);

                        Product product = new Product(productName, productValue, productQuantity);

                        sw.WriteLine($"Name: {product.Name} | TotalValue: {product.TotalValue().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
