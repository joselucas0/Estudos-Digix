using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
        public CatalogoDeLivros Catalogo { get; private set; } = new CatalogoDeLivros();

        public Biblioteca(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public Livro BuscarLivro(string titulo)
        {
            return Catalogo.BuscarLivroPorTitulo(titulo);
        }
    }

}
