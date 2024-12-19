using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class CatalogoDeLivros
    {
        private List<Livro> Livros { get; set; } = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public Livro? BuscarLivroPorTitulo(string titulo)
        {
            return Livros.FirstOrDefault(livro => livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}
