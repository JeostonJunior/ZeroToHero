using System;
using System.Collections.Generic;
using System.Linq;
namespace Conjuntos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashClass<string> set = new HashClass<string>();
            set.AddValue("hash");
            set.Print();
        }
    }
}
