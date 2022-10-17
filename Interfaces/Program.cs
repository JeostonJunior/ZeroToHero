using Interfaces.Models.Entities;
using System;
using System.Globalization;

namespace Interfaces
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup ");
            DateTime datePickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return ");
            DateTime dateReturn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double dayPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(datePickup, dateReturn, new Vehicle(carModel));

            RentalService rentalService = new RentalService(hourPrice, dayPrice);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");

            Console.WriteLine(carRental.Invoice);            
        }
    }
}
