using System;
using System.Collections.Generic;

class Dio
{
    static void Main(string[] args)
    {
        List<string> NumbersList = new List<string>();

        int qt = int.Parse(Console.ReadLine());

        for (int j = 0; j < qt; j++)
        {
            var A = Console.ReadLine();
            var B = Console.ReadLine();

            NumbersList.Add(A.ToString());
            NumbersList.Add(B.ToString());

            if (NumbersList[1].Count() > NumbersList[0].Count())
            {
                Console.WriteLine($"nao encaixa");
                NumbersList = new List<string>();
            }
            else
            {
                var contador = NumbersList[0].Count() - 1;
                var sum = 0;
                for (var i = NumbersList[1].Count() - 1; i > 0; i--)
                {
                    if (NumbersList[1][i] == NumbersList[0][contador])
                    {
                        sum++;
                        contador--;
                    }
                    else
                    {
                        Console.WriteLine($"nao encaixa");
                    }
                }
                if (sum == NumbersList[1].Count() - 1)
                {
                    Console.WriteLine($"encaixa");
                }
                NumbersList = new List<string>();
            }
        }
    }

}
