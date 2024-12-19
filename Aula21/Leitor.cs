using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class Leitor : Usuario
    {
        public List<Livro> LivrosEmprestados { get; private set; } = new List<Livro>();

        public Leitor(string nome, string id) : base(nome, id) { }

        public void EmprestarLivro(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        public void DevolverLivro(Livro livro)
        {
            LivrosEmprestados.Remove(livro);
        }

        public override string ExibirInformacoes()
        {
            return $"Leitor: {Nome}, ID: {Id}, Livros Emprestados: {LivrosEmprestados.Count}";
        }
    }
}
