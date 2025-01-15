// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula27
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             string filepath = "dados.bin";
//             using (BinaryReader reader = new BinaryReader(File.Open(filepath, FileMode.Open)))
//             {
//                 int numeroInteiro = reader.ReadInt32();
//                 double numeroDouble = reader.ReadDouble();
//                 string texto = reader.ReadString();
//                 Console.WriteLine("Numero inteiro: " + numeroInteiro);
//                 Console.WriteLine("Numero double: " + numeroDouble);
//                 Console.WriteLine("Texto: " + texto);

//             }
//         }
//     }
// }