using Exceptions.Entities;
using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main (string[] args)
        {
			try
			{
				Console.WriteLine("Entre com os dados da reserva:");
				Console.Write("Numero do Quarto: ");
				int roomNumber = int.Parse(Console.ReadLine());
				Console.Write("CheckIn: ");
				DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CheckOut: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                while (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("As reservas devem ser para datas futuras;");
                    Console.Write("CheckIn: ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("CheckOut: ");
                    checkOut = DateTime.Parse(Console.ReadLine());
                }
                while (checkOut <= checkIn)
				{
					Console.WriteLine("Data de Reserva Invalida, entre novamente com os dados;");
                    Console.Write("CheckIn: ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("CheckOut: ");
                    checkOut = DateTime.Parse(Console.ReadLine());
                }
				Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
				Console.WriteLine(reservation);
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }
    }
}
