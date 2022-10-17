namespace AluguelCarros.Models
{
    public class Taxa
    {
        public double TaxaBrasil (double amount)
        {
            if (amount >= 100.00)
            {
                return amount * 0.15;
            }
            return amount * 0.2;
        }
    }
}
