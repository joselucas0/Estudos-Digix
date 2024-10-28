using System;
using System.Collections.Generic;


namespace Program
{

    class Aluno
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
        //exibir dados do aluno
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Curso: {Curso.nomeCurso}");
            Curso.ExibirDisciplinas();
        }


    }
    class Curso
    {
        public string nomeCurso { get; set; }
        public int codigoCurso { get; set; }
        public List<Disciplina> Disciplinas { get; set; }


        public Curso(string nomeCurso, int codigoCurso)
        {
            this.nomeCurso = nomeCurso;
            this.codigoCurso = codigoCurso;
            Disciplinas = new List<Disciplina>();
        }


        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }


        public void RemoverDisciplina(Disciplina disciplina)
        {
            Disciplinas.Remove(disciplina);
        }
        
    
        public void ExibirDisciplinas()
        {
            Console.WriteLine($"Disciplinas do curso: {nomeCurso}");
            foreach (Disciplina disciplina in Disciplinas)
            {
                Console.WriteLine($"Nome: {disciplina.nomeDisciplina}, Código: {disciplina.codigoDisciplina}");
            }
        }
    }
    class Disciplina
{
    public string nomeDisciplina { get; set; }
    public int codigoDisciplina { get; set; }

    public Disciplina(string nomeDisciplina, int codigoDisciplina)
    {
        this.nomeDisciplina = nomeDisciplina;
        this.codigoDisciplina = codigoDisciplina;
    }

}



class Program
{
    static void Main(string[] args)
    {
        //criando um novo curso
        Curso curso = new Curso("Engenharia de Software", 1234);

        //criando disciplinas do curso
        Disciplina disciplina1 = new Disciplina("Programação Orientada a Objetos", 1);
        Disciplina disciplina2 = new Disciplina("Arquitetura de Software", 2);
        //adicionando disciplinas ao curso
        curso.AdicionarDisciplina(disciplina1);
        curso.AdicionarDisciplina(disciplina2);
        //criando um novo aluno
        Aluno aluno = new Aluno("José Lucas", 12345678, curso);
        //exibindo dados do aluno
        aluno.ExibirDados();
    }

    }

}