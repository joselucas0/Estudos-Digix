using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula24
{
    public class Program
    {
        static void Main(string[] args){
            int n1, n2, resultado;
            //try catch
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            try{
                resultado = n1 / n2;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Não é possível dividir por zero.");
            }
            
        }
    }
}