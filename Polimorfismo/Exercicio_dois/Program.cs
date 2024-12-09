namespace Exercicio_dois
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando instâncias de CompactDisc e Livro
            Produto cd = new CompactDisc(1, 29.90, "Leall", "Rock Danger");
            Produto livro = new Livro(2, 49.90, "George Orwell", 9780451524935);

            // Imprimindo informações
            System.Console.WriteLine(cd);
            System.Console.WriteLine(livro);

            // Atualizando preços
            cd.AtualizaPreco(34.90);
            livro.AtualizaPreco(54.90);

            System.Console.WriteLine("\nApós atualização de preços:");
            System.Console.WriteLine(cd);
            System.Console.WriteLine(livro);
        }
    }
}
