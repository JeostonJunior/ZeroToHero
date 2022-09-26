using System;

namespace Inheritance.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; protected set; }

        public SavingsAccount (int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance ()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw (double amount)
        {
            base.Withdraw (amount);
            Balance -= 2.00;
        }
    }
}
