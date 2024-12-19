using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, string isbn, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoPublicacao = anoPublicacao;
        }

        public string ExibirInformacoes()
        {
            return $"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Ano: {AnoPublicacao}";
        }
    }
}
