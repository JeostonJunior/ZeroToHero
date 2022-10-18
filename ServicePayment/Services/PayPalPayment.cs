namespace ServicePayment.Services
{
    public class PayPalPayment : IServicePayment
    {
        private const double FEE_PERCENTAGE = 0.02;
        private const double MONTHLY_INTEREST = 0.01;

        public double Tax (double value, int installments)
        {
            return value * MONTHLY_INTEREST * installments;
        }
        public double PaymentFee (double amount)
        {
            return amount * FEE_PERCENTAGE;
        }
    }
}
