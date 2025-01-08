using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula22_1
{
    public class Instrutor : Coordenador
    {
        public virtual void Salario(int salario)
                {
                    Console.WriteLine("Salário base: " + salario * 1.3);
                }

            public virtual void Trabalhar()
                {
                    Console.WriteLine("Instruindo...");
                }
    }
}