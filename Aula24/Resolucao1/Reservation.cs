using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resolucao1
{
    public class Reservation
    {
        public int RumNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int rumNumber, DateTime checkIn, DateTime checkOut)
        {
            RumNumber = rumNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan timeSpan = CheckOut - CheckIn;
            return (int)timeSpan.TotalDays;
        }

        public override string ToString()
        {
            return $"Quarto: {RumNumber}, Check-in: {CheckIn:dd/MM/yyyy}, Check-out: {CheckOut:dd/MM/yyyy}, Duração: {Duration()} noites.";
        }
    }
}