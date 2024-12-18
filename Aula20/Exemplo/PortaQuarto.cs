using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class PortaQuarto : Porta
    {
        public float MetragemQuadrada { get; set; }
        public string Extencao { get; set; }
        public PortaQuarto(string cor, float largura, float altura, double peso, string extencao, float metragemQuadrada ) : base(cor, largura, altura, peso)
        {
            Extencao = extencao;
            MetragemQuadrada = metragemQuadrada;
        }

        public override void Abrir()
        {
            Console.WriteLine("Porta do quarto aberta");
        }

        public override void Fechar()
        {
            Console.WriteLine("Porta do quarto fechada");
        }
    }
}