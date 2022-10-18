using Interfaces.Models.Entities;
using System;

namespace Interfaces.Models.Services
{
    public class RentalService
    {
        public double HourValue { get; private set; }
        public double DayValue { get; private set; }

        private readonly ITaxService _taxService;

        public RentalService (double hourValue, double dayValue, ITaxService taxService)
        {
            HourValue = hourValue;
            DayValue = dayValue;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
