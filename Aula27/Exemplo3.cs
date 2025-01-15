// using System;
// using System.IO;
// using System.Text;
// using System.Security.Cryptography;

// namespace Aula27
// {
//     public class Exemplo3
//     {
//         public static void Main(string[] args)
//         {
//             string original = "arquivo_original.txt";
//             string encryptFile = "arquivo_encrypt.txt";
//             string decryptFile = "arquivo_decrypt.txt";

//             // Criação do arquivo original
//             File.WriteAllText(original, "Este é o texto original");
//             Console.WriteLine("Arquivo original criado.");

//             string password = "Minhasenha";

//             // Criptografar o arquivo
//             EncryptFile(original, encryptFile, password);
//             Console.WriteLine("Arquivo criptografado.");

//             // Descriptografar o arquivo
//             DecryptFile(encryptFile, decryptFile, password);
//             Console.WriteLine("Arquivo descriptografado.");
//         }

//         public static void EncryptFile(string inputFile, string outputFile, string password)
//         {
//             byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
//             byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

//             using (Aes aes = Aes.Create())
//             {
//                 aes.Key = key;
//                 aes.IV = iv;

//                 using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
//                 using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
//                 using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
//                 {
//                     inputFileStream.CopyTo(cryptoStream);
//                 }
//             }
//         }

//         public static void DecryptFile(string inputFile, string outputFile, string password)
//         {
//             byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); 
//             byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); 

//             using (Aes aes = Aes.Create())
//             {
//                 aes.Key = key;
//                 aes.IV = iv;

//                 using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
//                 using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
//                 using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
//                 {
//                     cryptoStream.CopyTo(outputFileStream);
//                 }
//             }
//         }
//     }
// }
