using System;

namespace Encapsulamento
{
    class TestingEncapsulamento
    {
        static void Main(string[] args)
        {
            EncapsulamentoProduct productEncapsulado = new EncapsulamentoProduct("Laranja", 10.00, 5);

            Console.WriteLine($"{productEncapsulado.GetPrice()}");
        }
    }
}