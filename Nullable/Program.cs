using System;
namespace Nullable
{
    static class Nullable
    {
        static void Main(string[] args)
        {
            //forma pedreiro de declarar um nullable
            Nullable<double> x = null;

            //melhor forma de declarar um nullable
            double? x1 = 10.00;

            //operador de coalescencia nula
            double x2 = x ?? 0.0;

            Console.WriteLine($"X2: {x2}");

            //Pega o valor da variavel ou atribui 0 caso seja nullable
            Console.WriteLine($"Value: {x.GetValueOrDefault()}");

            // Verifica se existe um valor atribuido a variavel
            Console.WriteLine(x.HasValue);

            //captura o valor atribuido a variavel, caso seja nullable da erro
            // Console.WriteLine($"{x1.Value}");
            // Console.WriteLine($"{x.Value}");

            if (x.HasValue)
            {
                Console.WriteLine($"{x.Value}");
            }
            else
            {
                Console.WriteLine($"{x1.Value}");
            }
        }
    }
}