using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Cozinha
    {
        
        public PortaCozinha? PortaCozinha { get; set; }
        
        public float MetragemQuadrada { get; set; }

        public bool Americana { get; set; }

        
        public Cozinha(float metragemQuadrada, bool americana)
        {
            MetragemQuadrada = metragemQuadrada; 
            Americana = americana;
        }
       
        // Metodo entrou pela porta da cozinha
        public void Entrar (PortaCozinha? portaCozinha)
        {
            // Aqui esta ocorrendo a relação de Agregação
            Console.WriteLine("Entrou pela porta da cozinha" + portaCozinha?.Cor);
        }

    }
}