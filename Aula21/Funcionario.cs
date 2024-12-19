using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string id, string cargo) : base(nome, id)
        {
            Cargo = cargo;
        }

        public void RegistrarLivro(Livro livro, CatalogoDeLivros catalogo)
        {
            catalogo.AdicionarLivro(livro);
        }

        public override string ExibirInformacoes()
        {
            return $"Funcionário: {Nome}, ID: {Id}, Cargo: {Cargo}";
        }
    }
}
