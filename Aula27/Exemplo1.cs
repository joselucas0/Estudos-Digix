// using System;
// using System.IO;

// namespace Aula27
// {
//     public class Exemplo1
//     {
//         public static void Main(string[] args)
//         {
//             string filepath = "dados.bin";

//             // Usando BinaryWriter para gravar dados no arquivo
//             using (BinaryWriter writer = new BinaryWriter(File.Open(filepath, FileMode.Create)))
//             {
//                 writer.Write(1);              // Escreve um inteiro
//                 writer.Write(2.0);            // Escreve um double
//                 writer.Write("Hello World");  // Escreve uma string
//             }

//             Console.WriteLine("Dados gravados no arquivo: " + filepath);
//         }
//     }
// }
