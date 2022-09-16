using System.Globalization;
using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            Console.WriteLine($"Qual a dimensão da matriz?");
            int ordemMatriz = int.Parse(Console.ReadLine());
            matriz = new int[ordemMatriz,ordemMatriz];

            for (int i = 0; i < ordemMatriz; i++)
            {
                Console.WriteLine($"Informe os valores da linha {i+1}:");
                string[] valMatriz = Console.ReadLine().Split(' ');
                for (int x = 0; x < ordemMatriz; x++)
                {
                    matriz[i,x] = int.Parse(valMatriz[x]);
                }
            }            

            Console.WriteLine($"Main Diagonal:");
            for (int k = 0; k < matriz.GetLength(1); k++)
            {
                Console.Write($"|{matriz[k,k]}| ");
            }        


            int negativeNumbers = 0;
            foreach (var number in matriz)
            {
                if(number < 0){
                    negativeNumbers++;
                }
            }
            Console.WriteLine($"Negative Numbers: {negativeNumbers}");            
        }
    }
}