using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class PortaSala : Porta
{
    public float MetragemQuadrada { get; set; }

    public PortaSala(string cor, float largura, float altura, double peso, float metragemQuadrada)
        : base(cor, largura, altura, peso)
    {
        MetragemQuadrada = metragemQuadrada;
    }

    public override void Abrir()
    {
        Console.WriteLine("Porta da sala aberta");
    }

    public override void Fechar()
    {
        Console.WriteLine("Porta da sala fechada");
    }
}

}