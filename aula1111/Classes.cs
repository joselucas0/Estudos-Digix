using System;
using System.Collections.Generic;

namespace Program
{

    // Função para alterar o nome da disciplina

        
    
    // Classe Aluno
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public Curso Curso { get; set; }

        public Aluno(string nome, int matricula, Curso curso)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
        }

        // Método para exibir os dados do aluno
        public void ExibirDados()
        {
            Console.WriteLine($"Nome do Aluno: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso.Nome}");
            Console.WriteLine($"Tipo do objeto 'Curso' associado: {Curso.GetType()}"); // Exibe o tipo do objeto Curso
            Console.WriteLine("Disciplinas:");
            foreach (var disciplina in Curso.Disciplinas)
            {
                Console.WriteLine($"- {disciplina.Nome} (Semestre: {disciplina.Semestre})");
            }
        }
    }

    // Classe Curso
    public class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Curso(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Disciplinas = new List<Disciplina>();
        }

        // Método para adicionar disciplinas ao curso
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
    }

    // Classe Disciplina
    public class Disciplina
    {
        public string Nome { get; set; }
        public int Semestre { get; set; }

        public Disciplina(string nome, int semestre)
        {
            Nome = nome;
            Semestre = semestre;
        }


    }
}
