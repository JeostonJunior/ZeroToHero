using Inheritance.Entities;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main (string[] args)
        {
            //BusinessAccount account = new BusinessAccount(5000.0, 0001, "Big", 55000.00);

            //Console.WriteLine(account);

            Account acc = new Account(1000, "Big", 0.0);
            BusinessAccount bacc = new BusinessAccount(500.0, 0001, "Bob", 0.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(400.0, 0002, "Cab", 0.0);
            Account acc3 = new SavingsAccount(0003, "Sib", 7000.0, 0.01);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            //SavingsAccount acc5 = (SavingsAccount)acc2;
            //BusinessAccount acc6 = (BusinessAccount)acc1;
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE");
            }
            if (acc2 is SavingsAccount)
            {
                BusinessAccount acc6 = (BusinessAccount)acc2;
                Console.WriteLine("SUCESSO");
            }
        }
    }
}
