using System;
namespace AnimaisClasse{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma cobra
            Cobra cobra = new Cobra(true, true);
            cobra.Alimenta("rato");
            cobra.SetVenenosa(false);
            Console.WriteLine($"A cobra está viva: {cobra.Vivo}, é venenosa: {cobra.Venenosa}");

            // Criando um javali
            Javali javali = new Javali(true, true);
            Console.WriteLine($"O javali está vivo: {javali.Vivo}, é selvagem: {javali.Selvagem}");
            Console.WriteLine($"Velocidade máxima do javali: {javali.GetVelocidadeMaxima()} km/h");
            javali.SetSelvagem(false);
            Console.WriteLine($"Agora, o javali é selvagem: {javali.Selvagem}");
            Console.ReadKey();

        }
    }
}

