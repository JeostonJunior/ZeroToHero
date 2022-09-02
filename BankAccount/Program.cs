using System;
using System.Globalization;

namespace BankAccount
{
    class Bank
    {
        static void Main(string[] args)
        {
            BankAccount accountOne;
            double amount;

            Console.WriteLine($"Enter account number:");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter account name:");
            string accountName = Console.ReadLine();

            Console.WriteLine($"do you want to make a deposit?(S/N)");
            string response = Console.ReadLine();

            if (response == "S" || response == "s")
            {
                Console.WriteLine($"Enter with the amount to be deposited:");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                accountOne = new BankAccount(accountNumber, accountName, amount);
                Console.WriteLine($"{accountOne}");
            }
            else
            {
                accountOne = new BankAccount(accountNumber, accountName);
                Console.WriteLine($"{accountOne}");
            }

            Console.WriteLine($"Enter with the amount to be deposited:");
            double amountDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            accountOne.MakeDeposit(amountDeposit);
            Console.WriteLine($"Data Updated: {accountOne}");

            Console.WriteLine($"Enter with the amount to be drafted:");
            double draft = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            accountOne.MakeDraft(draft);
            Console.WriteLine($"Data Updated: {accountOne}");
        }
    }
}