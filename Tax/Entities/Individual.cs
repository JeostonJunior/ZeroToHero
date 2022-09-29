namespace Tax.Entities
{
    public class Individual : TaxPayers
    {
        public double HealthCost { get; set; }
        public Individual (string name, double yearIncome, double healthCost) : base(name, yearIncome)
        {
            HealthCost = healthCost;
        }
        public override double Tax ()
        {
            double taxCalculator;
            if (YearIncome < 20000.0)
            {
                taxCalculator = (YearIncome * 0.15) - (HealthCost * 0.50);
            }
            else
            {
                taxCalculator = (YearIncome * 0.25) - (HealthCost * 0.50);
            }
            return taxCalculator;
        }
    }
}
