using System;
using System.Globalization;
namespace Vetores
{
    static class Program
    {
        static void Main(string[] args)
        {
            double[] vetor;
            int n = int.Parse(Console.ReadLine());

            vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vetor[i];
            }
            Console.WriteLine($"A soma de todos os numeros é {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            double avg = sum / n;

            Console.WriteLine($"A media dos valores é {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}