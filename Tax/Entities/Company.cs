namespace Tax.Entities
{
    public class Company : TaxPayers
    {
        public int Employees { get; set; }

        public Company (string name, double yearIncome, int employees) : base(name, yearIncome)
        {
            Employees = employees;
        }
        public override double Tax ()
        {
            double taxCalculator;
            if (Employees > 10)
            {
                taxCalculator = YearIncome * 0.14;
            }
            else
            {
                taxCalculator = YearIncome * 0.16;
            }
            return taxCalculator;
        }
    }
}
