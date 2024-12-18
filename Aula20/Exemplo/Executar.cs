using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando Cozinha
            Console.WriteLine("=== Cozinha ===");
            Cozinha cozinha = new Cozinha(15.5f, true);
            Console.WriteLine($"Metragem da Cozinha: {cozinha.MetragemQuadrada}m²");
            Console.WriteLine($"É Americana: {cozinha.Americana}");
            cozinha.PortaCozinha?.Abrir();
            cozinha.PortaCozinha?.Fechar();

            Console.WriteLine();

            // Testando Quarto
            Console.WriteLine("=== Quarto ===");
            Quarto quarto = new Quarto(true, 12.0f);
            Console.WriteLine($"Metragem do Quarto: {quarto.MetragemQuadrada}m²");
            Console.WriteLine($"Possui Banheiro: {quarto.Banheiro}");
            quarto.Porta.Abrir();
            quarto.Porta.Fechar();

            Console.WriteLine();

            // Testando Sala
            Console.WriteLine("=== Sala ===");
            Sala sala = new Sala(20.0f);
            Console.WriteLine($"Metragem da Sala: {sala.MetragemQuadrada}m²");
            sala.PortaEntrada.Abrir();
            sala.PortaSala.Abrir();
            sala.PortaAuxiliar.Abrir();
            sala.PortaSala.Fechar();
        }
    }
}