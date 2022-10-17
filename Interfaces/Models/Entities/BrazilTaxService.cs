namespace Interfaces.Models.Entities
{
    public class BrazilTaxService
    {
        public double Tax (double ammount)
        {
            if (ammount <= 100.00)
            {
                return ammount * 0.2;
            }
            return ammount * 0.15;
        }
    }
}
