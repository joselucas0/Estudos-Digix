using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resolucao1
{
    public class Executar
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com o número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                if (checkIn < DateTime.Now || checkOut <= checkIn)
                {
                    throw new ArgumentException("Erro na reserva: Datas inválidas. Verifique se o check-in é no futuro e o check-out é após o check-in.");
                }

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reserva criada com sucesso: ");
                Console.WriteLine(reservation);

                // Atualização de datas
                Console.WriteLine("\nDeseja atualizar as datas da reserva? (s/n): ");
                if (Console.ReadLine().ToLower() == "s")
                {
                    Console.WriteLine("Entre com a nova data de Check-in (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Entre com a nova data de Check-out (dd/MM/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    if (checkIn < DateTime.Now || checkOut <= checkIn)
                    {
                        throw new ArgumentException("Erro na atualização: Datas inválidas. Verifique se o check-in é no futuro e o check-out é após o check-in.");
                    }

                    reservation.UpdateDate(checkIn, checkOut);
                    Console.WriteLine("Reserva atualizada com sucesso: ");
                    Console.WriteLine(reservation);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro: Entrada de dados inválida. Por favor, insira valores corretos.");
                Console.WriteLine($"Detalhes do erro: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado.");
                Console.WriteLine($"Detalhes do erro: {ex.Message}");
            }
        }
    
    }
}