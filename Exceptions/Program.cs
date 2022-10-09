using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main ()
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

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine("Entre com os dados para atualizar a reserva");
                Console.Write("CheckIn: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CheckOut: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro na Reserva: {e.Message}");        
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de Formato: {e.Message}");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine($"Possivel Campo Nulo: {e.Message}");
            }
            
        }
    }
}
