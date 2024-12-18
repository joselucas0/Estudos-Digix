using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Endereco
    {
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public Cidade? Cidade { get; set; }
    }
}