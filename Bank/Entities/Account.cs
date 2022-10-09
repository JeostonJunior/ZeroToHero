using Bank.Entities.Exceptions;
using System;
using System.Globalization;

namespace Bank.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0)
            {
                throw new AccountException("O valor informado de saldo é inválido;");
            }
            else if (withdrawLimit < 0)
            {
                throw new AccountException("O valor informado para o limite de saque inválido;");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw (double amount)
        {
            if (Balance == 0.00)
            {
                throw new AccountException("Não há saldo em conta;");
            }
            else if (amount > Balance)
            {
                throw new AccountException("O valor de saque excede o valor do saldo da conta;");
            }
            else if (amount > WithdrawLimit)
            {
                throw new AccountException("O valor de saque excede o valor do limite de saque;");
            }
            Balance -= amount;
            Console.WriteLine($"New Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
