using System;

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
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration ()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public string UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkOut < now || checkIn < now)
            {
                return "Erro na Reserva: As datas de reserva devem ser futuras;";
            }
            else if (checkOut <= checkIn)
            {
                return "Erro na Reserva: A data de Check-out deve ser maior que Check-in;";
            }
            else
            {
                CheckIn = checkIn;
                CheckOut = checkOut;
                return "Reserva Atualizada";
            }
        }
        public override string ToString ()
        {
            return $"Reservation: Room {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")}, Check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}
