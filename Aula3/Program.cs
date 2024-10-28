using System;


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
        }
    
        public void ExibirDisciplinas()
        {
            Console.WriteLine("Disciplinas do curso: {nomeCurso}");
            foreach (Disciplina disciplina in Disciplinas)
            {
                Console.WriteLine($"Nome: {disciplina.Nome}, Código: {disciplina.Codigo}");
            }
        }

    }
    class Disciplina
{
    public string nomeDisciplina { get; set; }
    public int codigoDisciplina { get; set; }


}



class Program
{
    static void Main(string[] args)
    {

    }

}

    }
