using Generics.Services;
using System;

namespace Generics
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.Write("How many values? ");
            int value = int.Parse(Console.ReadLine());
            PrintService<string> printService = new PrintService<string>();       
            for (int i = 0; i < value; i++)
            {
                string number = Console.ReadLine();
                printService.AddValue(number);
            }
            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
