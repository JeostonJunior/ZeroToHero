namespace ServicePayment.Services
{
    public interface IServicePayment
    {
        double PaymentFee (double amount);
        double Tax (double value, int installments);
    }
}
