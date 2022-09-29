namespace AbstractAccount.Entities
{
    public abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account (int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //public void Withdraw (double amount)
        //{
        //    Balance -= amount;
        //}

        //VIRTUAL - ESPAÇO PARA SOBREPOSIÇÃO
        public virtual void Withdraw (double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

    }
}