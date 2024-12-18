using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Vendedor : Funcionario
{
    public EquipeVenda? Equipe { get; set; }

    public float GetSalario()
    {
        return 2500.0f;
    }
}
}