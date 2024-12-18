using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Quarto
    {
    public PortaQuarto Porta { get; set; }
    public bool Banheiro { get; set; }
    public float MetragemQuadrada { get; set; }

    public Quarto(bool banheiro, float metragemQuadrada)
    {
        Banheiro = banheiro;
        MetragemQuadrada = metragemQuadrada;

        // Inicializando a porta corretamente
        Porta = new PortaQuarto("Marrom", 0.80f, 2.0f, 10.0, "Correr", metragemQuadrada);
    }
}

}