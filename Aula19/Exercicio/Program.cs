using System;

namespace Exercicio{

public class Program
{
    public static void Main(string[] args)
    {
        Formiga formiga = new Formiga();
        formiga.Caminha();
        formiga.Come();

        Cachorro cachorro = new Cachorro("Rex");
        cachorro.Caminha();
        cachorro.Come();
        cachorro.Brinca();
        Console.WriteLine("Nome do cachorro: " + cachorro.GetNome());

        Peixe peixe = new Peixe("Nemo");
        peixe.Caminha();
        peixe.Come();
        peixe.Brinca();
        Console.WriteLine("Nome do peixe: " + peixe.GetNome());
    }
}

}