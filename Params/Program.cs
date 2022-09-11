using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //REF
            // int result = 5;
            // Params.Triple(ref result);
            // Console.WriteLine($"{result}");
            //OUT
            int a = 10;
            int triple;
            Params.Triple(a, out triple);
            Console.WriteLine($"{triple}");
        }
    }
}
