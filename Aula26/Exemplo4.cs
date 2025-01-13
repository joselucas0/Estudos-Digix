// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula26_ManipulacaoArquivo
// {
//     public class Exemplo4
//     {
//         static void Main(string[] args)
       
//         {
//             string inicioParh = @"C:\Users\joselucas\Desktop\teste1.txt";
//             string finalParh = @"C:\Users\joselucas\Desktop\teste1.txt";

//             try
//             {
//                 string [] lines = File.ReadAllLines(inicioParh);

//                 using (StreamWriter sw = File.AppendText(finalParh))
//                 {
//                     foreach (string item in lines)
//                     {
//                         sw.WriteLine(item.ToUpper());
                        
//                     }
//                 }
//             }
//             catch (IOException e)
//             {
                
//                 System.Console.WriteLine("Ocorreu erro");
//                 System.Console.WriteLine(e.Message);
//             }
//         }
//     }
// }