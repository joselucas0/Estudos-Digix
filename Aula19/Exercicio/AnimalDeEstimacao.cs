using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public interface IAnimalDeEstimacao
    {
        string? GetNome();
        void SetNome(string? nome);
        void Brinca();
    }

}