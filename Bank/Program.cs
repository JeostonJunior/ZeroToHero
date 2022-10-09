using Bank.Entities;
using Bank.Entities.Exceptions;
using System;
using System.Globalization;

namespace Bank
{
    internal class Program
    {
        static void Main ()
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holderName = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(numberAccount, holderName, initialBalance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
            }
            catch (AccountException e)
            {
                Console.WriteLine($"Error Account: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error Format: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
