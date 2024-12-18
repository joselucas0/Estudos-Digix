using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Sala
    {
    public Porta PortaEntrada { get; set; }
    public PortaSala PortaSala { get; set; }
    public Porta PortaAuxiliar { get; set; }
    public float MetragemQuadrada { get; set; }

    public Sala(float metragemQuadrada)
    {
        MetragemQuadrada = metragemQuadrada;

        // Inicializando as portas
        PortaEntrada = new Porta("Vermelha", 1.0f, 2.2f, 15.0);
        PortaSala = new PortaSala("Cinza", 0.90f, 2.0f, 14.0, metragemQuadrada);
        PortaAuxiliar = new Porta("Branca", 0.80f, 2.1f, 12.0);
    }
}


}