// using System;

// namespace OrientacaoObj{
//     public class Cachorro{
        
//     //criar uma classe Cachorro
//     public string Nome {get; set;}
//     public string Raca {get; set;}
//     public int Idade {get; set;}
//     public double Peso {get; set;}

//     public void Latir(){
//         Console.WriteLine("Au, au! 🐶");
//     }

 
    
//     }


//     class Program{
//         //definir os atributos do Cachorro
//         static void Main(string[] args){
//             Cachorro rex = new Cachorro();
//             //perguntar os dados
//             Console.WriteLine("Nome do cachorro: ");
//             rex.Nome = Console.ReadLine();
            
//             Console.WriteLine("Raça do cachorro: ");
//             rex.Raca = Console.ReadLine();
            
//             Console.WriteLine("Idade do cachorro: ");
//             rex.Idade = int.Parse(Console.ReadLine());
            
//             Console.WriteLine("Peso do cachorro: ");
//             rex.Peso = double.Parse(Console.ReadLine());

            
//             //mostrar os dados
//             Console.WriteLine($"Nome: {rex.Nome}");
//             Console.WriteLine($"Raça: {rex.Raca}");
//             Console.WriteLine($"Idade: {rex.Idade} anos");
//             Console.WriteLine($"Peso: {rex.Peso} kg");

//             rex.Latir();
//         }

//     }
// }