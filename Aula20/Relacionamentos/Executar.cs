using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamentos
{
      public class Executar
    {
        static void Main(string[] args)
        {
            Escola e =  new Escola("João");

            Professor p = new Professor("Maria");
            e.ContratarProfessor(p);
            e.MostrarInfo();
        }
    }
}