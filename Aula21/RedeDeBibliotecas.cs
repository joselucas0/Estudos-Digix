using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public class RedeDeBibliotecas
    {
        private List<Biblioteca> Bibliotecas { get; set; } = new List<Biblioteca>();

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Add(biblioteca);
        }

        public Biblioteca BuscarBiblioteca(string nome)
        {
            return Bibliotecas.FirstOrDefault(b => b.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
    }
}
