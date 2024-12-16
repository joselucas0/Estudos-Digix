using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Peixe : Animal, IAnimalDeEstimacao
        {
            private string? nome;

            public Peixe()
            {
                // Construtor padrão
            }

            public Peixe(string nome)
            {
                this.nome = nome;
            }

            public string? GetNome()
            {
                return this.nome;
            }

            public void SetNome(string? nome)
            {
                this.nome = nome;
            }

            public void Brinca()
            {
                Console.WriteLine("O peixe está brincando.");
            }

            public override void Come()
            {
                Console.WriteLine("O peixe está comendo.");
            }
        }

}