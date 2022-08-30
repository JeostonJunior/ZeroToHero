using System;

class ChallengePottencial
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int iterator = 0;
        int sumNumbers = 0;
        int productNumbers = 1;

        while (number > 0 && number <= Math.Pow(10, 5))
        {
            iterator = number % 10;
            sumNumbers += iterator;
            productNumbers *= iterator;
            number /= 10;
        }
        Console.WriteLine($"Result: {productNumbers - sumNumbers}");
    }
}
