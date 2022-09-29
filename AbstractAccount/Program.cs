using AbstractAccount.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractAccount
{
    internal class Program
    {
        static void Main (string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(0001,"ANA",5000.0,0.01));
            accounts.Add(new BusinessAccount(400.0, 0002, "TAKE", 5000.0));
            accounts.Add(new SavingsAccount(0003, "JULY", 5000.0, 0.02));
            accounts.Add(new BusinessAccount(300.0, 0004, "CURUPIRA", 5000.0));

            double sum = 0.0;
            foreach (Account account in accounts)
            {
                sum += account.Balance;
            }
            Console.WriteLine($"Total Balace: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");

            foreach (Account account in accounts)
            {
                account.Withdraw(10.0);
            }
            foreach (Account account in accounts)
            {
                Console.Write($"[{account.Holder}-{account.Balance.ToString("F2", CultureInfo.InvariantCulture)}] ");               
            }
            Console.WriteLine("\n");
        }
    }
}