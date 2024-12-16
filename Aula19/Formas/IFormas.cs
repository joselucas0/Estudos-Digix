using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formas
{
    public interface IForma
    {
        string Nome { get; set; }

        double CalcularArea();

        void ExibirInformacoes();
    }
}
