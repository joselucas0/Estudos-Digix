// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.IO;

// namespace Aula_26
// {
//     public class Executar
//     {
//         static void Main(string[] args){
//             string inicioTXT = @"C:\Users\joselucas\Desktop\teste1.txt";
//             string fimTXT = @"C:\Users\joselucas\Desktop\teste2.txt";

//             try
//             {
//                 FileInfo fileInfo = new FileInfo(inicioTXT);
//                 fileInfo.CopyTo(fimTXT);
//                 foreach (string linha in File.ReadLines(fimTXT))
//                 {
//                     System.Console.WriteLine(linha);
//                 }
//             }
//             catch (IOException e)
//             {
                
//                 System.Console.WriteLine("Ocorreu um erro");
//                 System.Console.WriteLine(e.Message);
//             }
//         }
//     }
// }