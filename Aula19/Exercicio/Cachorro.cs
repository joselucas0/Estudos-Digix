using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Cachorro : Animal, IAnimalDeEstimacao
        {
            private string? nome;

            public Cachorro()
            {
                // Construtor padrão
            }

            public Cachorro(string nome)
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
                Console.WriteLine("O cachorro está brincando.");
            }

            public override void Come()
            {
                Console.WriteLine("O cachorro está comendo.");
            }
        }

}