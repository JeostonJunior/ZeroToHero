using System.Globalization;
using System;
namespace BankAccount
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public double Amount { get; private set; }

        public BankAccount(int accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
        }

        public BankAccount(int accountNumber, string accountName, double amount) : this(accountNumber, accountName)
        {
            MakeDeposit(amount);
        }

        public void MakeDeposit(double amountDeposit)
        {
            Amount += amountDeposit;
        }

        public void MakeDraft(double draft)
        {
            Amount -= draft + 5;
        }

        public override string ToString()
        {
            return $"Account {AccountNumber}, AccountName: {AccountName}, Amount: ${Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}