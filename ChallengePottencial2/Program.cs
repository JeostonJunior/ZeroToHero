class Dio
{
    static void Main(string[] args)
    {
        string[] vetor = new string[2];

        int qt = int.Parse(Console.ReadLine());

        for (int i = 0; i < qt; i++)
        {
            vetor = Console.ReadLine().Split(" ");

            string A = vetor[0];
            string B = vetor[1];

            if (A.EndsWith(B))
            {
                Console.WriteLine("encaixa");
            }
            else
            {
                Console.WriteLine("nao encaixa");
            }
        }
    }
}
