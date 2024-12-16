using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Formiga : Animal
        {
            public Formiga()
            {
                // Construtor padrão
            }

            public override void Come()
            {
                Console.WriteLine("A formiga está comendo.");
            }
        }

}
