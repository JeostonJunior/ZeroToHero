namespace Tax.Entities
{
    public abstract class TaxPayers
    {
        public string Name { get; set; }
        public double YearIncome { get; protected set; }

        protected TaxPayers (string name, double yearIncome)
        {
            Name = name;
            YearIncome = yearIncome;
        }

        public abstract double Tax ();
    }
}
