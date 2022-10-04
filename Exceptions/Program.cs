using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int n1, n2, result;
            try
            {
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
