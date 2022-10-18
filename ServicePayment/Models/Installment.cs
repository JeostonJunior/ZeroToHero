using System;

namespace ServicePayment.Models
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public double Ammount { get; set; }

        public Installment (DateTime dueDate, double ammount)
        {
            DueDate = dueDate;
            Ammount = ammount;
        }
    }
}
