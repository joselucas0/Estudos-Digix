using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Id { get; set; }

        protected Usuario(string nome, string id)
        {
            Nome = nome;
            Id = id;
        }

        public abstract string ExibirInformacoes();
    }
}
