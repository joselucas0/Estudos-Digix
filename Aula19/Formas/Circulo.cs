using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formas
{
   public class Circulo : IForma
        {
            public string Nome { get; set; }
            public double Raio { get; set; }

            public Circulo(double raio)
                {
                    Nome = "Círculo";
                    Raio = raio;
                }

            public double CalcularArea()
                {
                    return Math.PI * Math.Pow(Raio, 2);
                }

            public void ExibirInformacoes()
                {
                    Console.WriteLine($"Forma: {Nome}");
                    Console.WriteLine($"Raio: {Raio}");
                    Console.WriteLine($"Área: {CalcularArea():F2}");
                }
        }
}