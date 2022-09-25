using Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main (string[] args)
        {
            BusinessAccount account = new BusinessAccount(5000.0, 0001, "Big", 55000.00);

            Console.WriteLine(account);
        }
    }
}
