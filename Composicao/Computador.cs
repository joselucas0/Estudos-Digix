using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class Computador
    {
        private Processador processador;

        public Computador()
        {
            // Composição: O computador possui um processador
            processador = new Processador();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando o computador...");
            processador.Processar(); // Chamando o método processar do processador
        }
    }
}