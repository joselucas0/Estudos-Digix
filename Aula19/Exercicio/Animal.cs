using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
        public abstract class Animal
    {
        protected int pernas = 0;

        public Animal()
        {
            // Construtor padrão
            
        }

        public void Caminha()
        {
            Console.WriteLine("O animal está caminhando.");
        }

        public abstract void Come();
    }

}