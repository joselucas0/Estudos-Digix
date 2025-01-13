// using System;
// using System.Collections.Generic;
// using System.IO;

// namespace Aula_26
// {
//     public class Exemplo5
//     {
//         static void Main(string[] args)
//         {
//             string path = @"C:\Users\joselucas\Desktop\teste";

//             try
//             {
//                 // Obtém todos os arquivos dentro das subpastas
//                 IEnumerable<string> pastas = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

//                 Console.WriteLine("Arquivos encontrados:");
//                 foreach (var item in pastas)
//                 {
//                     Console.WriteLine(item);
//                 }
//                 bool existe = Directory.Exists(path + @"/Nova");
//                 System.Console.WriteLine("Pasta nova exite: ");



//             }
//             catch (Exception e) // Nomeando a exceção
//             {
//                 Console.WriteLine("Ocorreu um erro:");
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }
