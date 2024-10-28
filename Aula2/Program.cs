using System;

namespace Aula_2{
    class Program
    {
            static void Main(string[] args){
        int numero1 = 5, numero2 = 10, resultado, mult, div;
        resultado = numero1 + numero2;
        Console.WriteLine("A soma de {0} e {1} é {2}", numero1, numero2, resultado);
        mult = numero1 * numero2;
        div = numero1 / numero2;
        Console.WriteLine("A multiplicação de {0} e {1} é {2}", numero1, numero2, mult);
        Console.WriteLine("A divisão de {0} e {1} é {2}", numero1, numero2, div);
        double raiz = Math.Sqrt(numero1);
        Console.WriteLine("A raiz quadrada de {0} é {1}", numero1, raiz);

        //incrementando um número
        numero1++;
        Console.WriteLine("Incrementando um número: {0}", numero1);
        //operadores de comparação
        if(numero1 > numero2){
            Console.WriteLine("{0} é maior que {1}", numero1, numero2);
            }else if(numero1 < numero2){
            Console.WriteLine("{0} é menor que {1}", numero1, numero2);
            } else{
            Console.WriteLine("{0} é igual a {1}", numero1, numero2);
            }
        }
    }
    }