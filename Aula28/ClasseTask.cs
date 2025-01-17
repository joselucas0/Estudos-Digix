using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula28
{
    public class Classelask
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Inicio do programa");
            int resultado = await Soma(10, 20); // Aguarda o resultado da soma
            Console.WriteLine("Resultado: " + resultado);
        }

        // Soma dois números de forma assíncrona
        static async Task<int> Soma(int a, int b)
        {
            // Simulação de uma operação assíncrona (substitua por uma operação real)
            return Task.Delay(1000); // Aguarda 1 segundo

            return a + b;
        }
    }
}