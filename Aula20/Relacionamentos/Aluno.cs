using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamentos
{
     public class Aluno
    {
        // Propriedades
        public string Nome { get; set; }

        // Construtor
        public Aluno(string nome)
        {
            Nome = nome;
        }

        //Funcao informar
        public void Informar()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}