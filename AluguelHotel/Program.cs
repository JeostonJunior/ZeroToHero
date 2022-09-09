using System;

namespace AluguelHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] estudantes = new Estudantes[10];

            Console.WriteLine($"Quantos quartos deseja alugar?:");

            int quarto = int.Parse(Console.ReadLine());

            while (quarto > 10 || quarto < 0)
            {
                Console.WriteLine($"Valor invalido");
                quarto = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quarto; i++)
            {
                Console.WriteLine($"\nEstudante #{i + 1}");

                Console.WriteLine($"\nNome:");
                string nome = Console.ReadLine();

                Console.WriteLine($"\nEmail:");
                string email = Console.ReadLine();

                Console.WriteLine($"\nQuarto:");
                int quartoAlugado = int.Parse(Console.ReadLine());

                estudantes[quartoAlugado] = new Estudantes(nome, email);
            }

            Console.WriteLine($"\nQuartos Alugados:");
            for (int i = 0; i < estudantes.Length; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i].Nome}, {estudantes[i].Email}");
                }
            }

        }
    }
}