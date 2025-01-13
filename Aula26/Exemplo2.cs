// using System;
// using System.IO;

// namespace Projeto.Aula26
// {
//     class Exemplo2
//     {
//         static void Main(string[] args)
//         {
//             string inicioTXT = @"C:\Users\joselucas\Desktop\teste1.txt";
//             FileStream fs = new FileStream(inicioTXT, FileMode.Open);
//             StreamReader sr = new StreamReader(fs);
//             try
//             {
                
//                 string? line;
//                 while ((line = sr.ReadLine()) != null)
//                 {
//                     Console.WriteLine(line);
//                 }
                
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Ocorreu um erro de: " + ex.Message);
//             }
//             finally
//             {
                
//                 if (sr != null)
//                 {
//                     sr.Close();
//                 }
//                 if (fs != null)
//                 {
//                     fs.Close();
//                 }
//             }
//         }
//     }
// }