using System;
using aula1111;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um novo curso
            var curso = new Curso("Engenharia de Software", 1234);

            // Criando disciplinas do curso
            var disciplina1 = new Disciplina("Programação Orientada a Objetos", 1);
            var disciplina2 = new Disciplina("Arquitetura de Software", 2);

            // Adicionando disciplinas ao curso
            curso.AdicionarDisciplina(disciplina1);
            curso.AdicionarDisciplina(disciplina2);

            // Criando um novo aluno
            var aluno = new Aluno("José Lucas", 12345678, curso);

            // Exibindo dados do aluno
            aluno.ExibirDados();

            var pessoa = "joao";
            Console.WriteLine(pessoa);

            // Pedindo o novo nome da disciplina ao usuário
            Console.WriteLine("Digite o novo nome da disciplina:");
            var novoNome = Console.ReadLine();

            // Alterando nome da disciplina com o método AlterarNomeDisciplina
            NewClass.AlterarNomeDisciplina(ref curso, disciplina1.Nome, novoNome);
        }
    }
}