using System;

namespace Interfaces.Models.Entities
{
    public class CarRental
    {
        public DateTime Initial { get; set; }
        public DateTime Final { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }
        public CarRental (DateTime initial, DateTime final, Vehicle vehicle)
        {
            Initial = initial;
            Final = final;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
