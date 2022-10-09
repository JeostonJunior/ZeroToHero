using System;
using Exceptions.Entities.Exceptions;

namespace Exceptions.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; protected set; }
        public DateTime CheckIn { get; protected set; }
        public DateTime CheckOut { get; protected set; }

        public Reservation (int roomNumber)
        {
            RoomNumber = roomNumber;
        }
        public Reservation (int roomNumber, DateTime checkIn, DateTime checkOut) : this (roomNumber)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de Check-out deve ser maior que Check-in;");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration ()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkOut < now || checkIn < now)
            {
                throw new DomainException("As datas de reserva devem ser futuras;");
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("A data de Check-out deve ser maior que Check-in;");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString ()
        {
            return $"Reservation: Room {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")}, Check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}
