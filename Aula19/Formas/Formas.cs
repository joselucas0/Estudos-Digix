using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formas
{
    
        public class Forma : IForma
            {
                public string Nome { get; set; }

                public Forma(string nome)
                    {
                        Nome = nome;
                    }

                // Método virtual para ser sobrescrito nas classes filhas
                public virtual double CalcularArea()
                    {
                        return 0; // Implementação padrão
                    }

                public virtual void ExibirInformacoes()
                    {
                        Console.WriteLine($"Forma: {Nome}");
                    }
            }
    
}