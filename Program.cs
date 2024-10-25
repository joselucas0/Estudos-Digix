 using System;

 public class Program
 {
     public static void Main()
     {
         Console.WriteLine("Digite o primeiro lado do triângulo:");
         int lado1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Digite o segundo lado do triângulo:");
         int lado2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Digite o terceiro lado do triângulo:");
         int lado3 = Convert.ToInt32(Console.ReadLine());

         if (ETrianguloValido(lado1, lado2, lado3))
         {
             double semiperimetro = (lado1 + lado2 + lado3) / 2.0;
             double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

             Console.WriteLine($"Área do triângulo: {area:F2}");
         }
         else
         {
             Console.WriteLine("Os lados fornecidos não podem formar um triângulo válido.");
         }
     }
     //calculo area quadrado
     public static double AreaQuadrado(int lado)
     {  
        int lado;
         Console.WriteLine("Digite o lado do quadrado:");
     //calculo area quadrado
     public static double AreaQuadrado(int lado)
     {  
         return Math.Pow(lado, 2);
     }
         lado = Convert.ToInt32(Console.ReadLine());
         return Math.Pow(lado, 2);
     }
    

     public static bool ETrianguloValido(int a, int b, int c)
     {
         return (a + b > c) && (a + c > b) && (b + c > a);
     }
 }