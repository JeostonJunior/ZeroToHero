using System;

namespace Interfaces.Models.Entities
{
    public class RentalService
    {
        public double HourValue { get; set; }
        public double DayValue { get; set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService (double hourValue, double dayValue)
        {
            HourValue = hourValue;
            DayValue = dayValue;
        }
        public void ProcessInvoice (CarRental carRental)
        {
            TimeSpan duration = carRental.Final.Subtract(carRental.Initial);

            double basicPayment = 0.00;
            if (duration.TotalHours <= 12.00)
            {
                basicPayment = HourValue * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = DayValue * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
