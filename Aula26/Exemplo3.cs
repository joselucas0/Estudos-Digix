// using System;
// using System.IO;


// namespace Exemplo3{
    
// class Exemplo3
// {
//     static void Main(string[] args)
//     {
//         string inicioParh = @"C:\Users\joselucas\Desktop\teste1.txt";

//         FileStream? fs = null;
//         StreamReader? sr = null;

//         try
//         {
//             fs = new FileStream(inicioParh, FileMode.Open);
//             sr = new StreamReader(fs);

//             string? line = sr.ReadLine();
//             Console.WriteLine(line);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Ocorreu um erro de: " + ex.Message);
//         }
//         finally
//         {
//             if (sr != null)
//             {
//                 sr.Close();
//             }
//             if (fs != null)
//             {
//                 fs.Close();
//             }
//         }
//     }
// }

// }