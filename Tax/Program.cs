using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Entities;

namespace Tax
{
    public class Program
    {
        static void Main (string[] args)
        {
            List<TaxPayers> payers = new List<TaxPayers>();
            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                if (option.Equals('i'))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expeditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payers.Add(new Individual(name, anualIncome, healthExp));
                }
                if (option.Equals('c'))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Numbers of employees");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, employees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0.0;
            foreach(TaxPayers Payers in payers)
            {
                Console.WriteLine($"{Payers.Name}: ${Payers.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += Payers.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: ${totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");



        }
    }
}
