namespace AbstractAccount.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount (int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance ()
        {
            Balance += Balance * InterestRate;
        }

        //ESSE METODO NÃO PODE SER SOBRESCRITA NOVAMENTE EM OUTRA CLASSE 
        public sealed override void Withdraw (double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;
        }
    }
}