using System;

namespace Encapsulamento
{
    class TestingEncapsulamento
    {
        static void Main(string[] args)
        {
            EncapsulamentoProduct productEncapsulado = new EncapsulamentoProduct("Laranja", 10.00, 5);
            productEncapsulado.Name = "Água";
            productEncapsulado.Price = 2.50;

            Console.WriteLine($"{productEncapsulado}");
        }
    }
}