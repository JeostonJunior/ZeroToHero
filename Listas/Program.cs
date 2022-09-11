using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Metodo Add, adiciona ao final da lista
            list.Add("Carro");
            list.Add("Moto");
            list.Add("Bike");
            list.Add("Caminhão");

            //Metodo insert, insere na posição determinada
            list.Insert(2, "Quadriciculo");

            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }

            //Metodo Count, mostra o tamanho da lista
            Console.WriteLine($"List Count: {list.Count}");

            //Metodo Find, procura uma ocorrencia na lista usando função anonima
            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine($"{s1}");

            //Metodo FindLast, procura uma ocorrencia na lista usando função anonima
            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine($"Ultima ocorrencia{s2}\n");

            //Metodo FindIndex
            int pos1 = list.FindIndex(x => x[0] == 'B');
            Console.WriteLine($"Primeira Posição {pos1}\n");

            //Metodo FindLastIndex
            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine($"Ultima Posição {pos2}\n");

            //FindAll, é nescessario a declaração de uma nova lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine($"Elementos de tamanho == 5");
            foreach (var item in list2)
            {
                Console.WriteLine($"{item}");
            }

            //Remove
            Console.WriteLine($"List Remove\n");
            list.Remove("Carro");

            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }

            //RemoveAll, precisa de um predicado
            Console.WriteLine($"List RemoveAll\n");
            list.RemoveAll(x => x[0] == 'B');
            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }

            //RemoveAt, precisa da posição exata na lista
            Console.WriteLine($"--RemoveAt\n");
            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }

            //Remove Range, remove os elementos em uma faixa
            Console.WriteLine($"--RemoveRange\n");

            list.RemoveRange(0, 1);
            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
