namespace Aula18{
     public class Executar
    {
        public static void Main(string[] args)
        {
            Produto p = new Produto("TV", 2100.00, 10);

            p.Nome = "Boombox";
            p.Preco = 2300.00;
            p.Quantidade = 2;

            System.Console.WriteLine($"Valor total em estoque: {p.ValorTotalEmEstoque():F2}");
            System.Console.WriteLine(p);

            p.Quantidade = 10;
            System.Console.WriteLine($"Valor total em estoque: {p.ValorTotalEmEstoque():F2}");
        }
    }
}