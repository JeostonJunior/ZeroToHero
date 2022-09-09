using System;
using System.Globalization;
namespace Vetores
{
    static class Program
    {
        static void Main(string[] args)
        {
            Products[] vetor;

            int n = int.Parse(Console.ReadLine());

            vetor = new Products[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nome do Produto:");
                string name = Console.ReadLine();

                Console.WriteLine($"Valor do Produto:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Products(name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vetor[i].Price;
            }
            Console.WriteLine($"A soma de todos os numeros é {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            double avg = sum / n;

            Console.WriteLine($"A media dos valores é {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}