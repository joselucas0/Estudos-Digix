using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamentos
{
    public class Escola
    {
        
        // Composicao:
        private Aluno aluno;
        private Professor? professor;

        public Escola(string nomeAluno)
        {
            aluno = new Aluno(nomeAluno);
        }

        public void ContratarProfessor(Professor professor)
        {
             this.professor = professor;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {aluno.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor?.Nome}");
            professor?.Ensinar();
        }
     }
    
    }
