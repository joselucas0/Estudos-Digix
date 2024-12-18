using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamentos
{
    public class Professor
    {
        public string Nome { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Ensinar()
        {
            Console.WriteLine($"{Nome} está ensinando");
        }
    }
}