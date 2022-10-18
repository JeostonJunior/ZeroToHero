using ServicePayment.Models;
using System;

namespace ServicePayment.Services
{
    public class FinalService
    {
        private readonly IServicePayment _servicePayment;

        public FinalService (IServicePayment servicePayment)
        {
            _servicePayment = servicePayment;
        }
        public void ProcessContract (Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 0; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _servicePayment.Tax(basicQuota, i);
                double fullQuota = updateQuota + _servicePayment.PaymentFee(updateQuota);
                contract.Installments.Add(new Installment(date, fullQuota));
            }
        }
    }
}
