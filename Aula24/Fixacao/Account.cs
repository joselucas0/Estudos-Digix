using System;

namespace Fixacao
{
    public class Reservationa
    {
        public int RoomNumber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        // Construtor
        public Reservationa(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new ArgumentException("Erro na reserva: A data de check-out deve ser posterior à data de check-in.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // Método para calcular a duração da estadia
        public int Duration()
        {
            return (CheckOut - CheckIn).Days;
        }

        // Método para atualizar as datas de check-in e check-out
        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new ArgumentException("Erro na atualização: A data de check-out deve ser posterior à data de check-in.");
            }

            if (checkIn < DateTime.Now)
            {
                throw new ArgumentException("Erro na atualização: A data de check-in deve ser no futuro.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // Sobrescrevendo o método ToString para exibir os detalhes da reserva
        public override string? ToString()
        {
            return $"Quarto: {RoomNumber}, Check-in: {CheckIn:dd/MM/yyyy}, Check-out: {CheckOut:dd/MM/yyyy}, " +
                   $"Duração: {Duration()} noite(s)";
        }
    }
}
