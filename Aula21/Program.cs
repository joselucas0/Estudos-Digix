using System;
using System.Numerics;
using Aula21;

class Program
{
    static void Main(string[] args)
    {
        // Criar livros
        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "123456789", 1954);
        Livro livro2 = new Livro("1984", "George Orwell", "987654321", 1949);

        // Criar uma biblioteca
        Biblioteca biblioteca = new Biblioteca("Biblioteca Central", "Rua Principal, 123");

        // Criar funcionários
        Funcionario funcionario = new Funcionario("Ana", "F001", "Bibliotecária");
        biblioteca.AdicionarFuncionario(funcionario);

        // Registrar livros no catálogo da biblioteca
        funcionario.RegistrarLivro(livro1, biblioteca.Catalogo);
        funcionario.RegistrarLivro(livro2, biblioteca.Catalogo);

        // Criar leitor
        Leitor leitor = new Leitor("Carlos", "L001");

        // Leitor empresta um livro
        leitor.EmprestarLivro(livro1);

        // Exibir informações
        Console.WriteLine(biblioteca.BuscarLivro("1984")?.ExibirInformacoes());
        Console.WriteLine(leitor.ExibirInformacoes());
        Console.WriteLine(funcionario.ExibirInformacoes());
    }
}
