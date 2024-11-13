using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Program;
using static Program.Aluno;
using static Program.Curso;

namespace aula1111
{
    public class NewClass
    {

        public static void AlterarNomeDisciplina(ref Curso curso, string nomeAntigo, string novoNome)
        {
            var disciplina = curso.Disciplinas.Find(d => d.Nome == nomeAntigo);
            if (disciplina != null)
            {
                disciplina.Nome = novoNome;
            }
            else
            {
                Console.WriteLine("Disciplina não encontrada.");
            }
        }
        
    }
}