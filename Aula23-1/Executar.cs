using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula22_1
{
    public class Executar
    {
        static void Main(string[] args){
            Funcionario f = new Funcionario();
             f.Salario(1000);
             f.Nome = "Jose";
             System.Console.WriteLine("Nome: " + f.Nome);
             f.Trabalhar();

             Gerente g = new Gerente();
             g.Salario(1000);
             g.Nome = "Maria";
             System.Console.WriteLine("Nome: " + g.Nome);
             g.Trabalhar();
             Coordenador c = new Coordenador();
             c.Salario(1000);
             c.Trabalhar();


             

             

        }
    }
}