using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula22_1
{
    public class Coordenador : Funcionario
    {
        public virtual void Salario(int salario)
            {
                    Console.WriteLine("Salário base: " + salario * 1.3);
            }
        public virtual void Trabalhar()
            {
                Console.WriteLine("Coordenando...");
            }
        
    }
}