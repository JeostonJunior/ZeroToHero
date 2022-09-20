using System.Globalization;

namespace DesafioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Entre com a dimensão da Matriz:");
            string[] dimensao = Console.ReadLine().Split(' ');
            int[,] matriz = new int[int.Parse(dimensao[0]), int.Parse(dimensao[1])];

            for (int i = 0; i < int.Parse(dimensao[0]); i++)
            {
                Console.WriteLine($"Entre com os valores da linha {i+1}:");
                string[] linha = Console.ReadLine().Split(' ');
                for (int k = 0; k < int.Parse(dimensao[1]); k++)
                {
                    matriz[i,k] = int.Parse(linha[k]);
                }                
            }

            Console.WriteLine($"Qual número deseja procurar?:");
            int findNumber = int.Parse(Console.ReadLine());


            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if(matriz[x,y].Equals(findNumber)){
                        Console.WriteLine($"Position [{x},{y}]");
                        if(y > 0){
                            Console.WriteLine($"Left: {matriz[x,y-1]}");
                        }
                        if(y < matriz.GetLength(1)-1){
                            Console.WriteLine($"Right: {matriz[x,y+1]}");
                        }
                        if(x > 0){
                            Console.WriteLine($"Up: {matriz[x-1,y]}");
                        }
                        if(x < matriz.GetLength(0)-1){
                            Console.WriteLine($"Down: {matriz[x+1,y]}");
                        }                        
                    }
                }
            }
        }
    }
}