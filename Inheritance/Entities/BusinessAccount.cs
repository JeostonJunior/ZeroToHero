namespace Inheritance.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount (double loan, int number, string holder, double balance) : base(number, holder, balance)
        {
            LoanLimit = loan;
        }

        public void Loan (double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string ToString ()
        {
            return $"{Number}, {Holder}, {Balance}, {LoanLimit}";
        }
    }
}
