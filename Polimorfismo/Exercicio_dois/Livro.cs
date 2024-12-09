namespace Exercicio_dois
{
    public class Livro : Produto
    {
        public string Autor { get; set; }
        public long ISBN { get; set; }

        public Livro(int codigo, double preco, string autor, long isbn)
            : base(codigo, preco)
        {
            Autor = autor;
            ISBN = isbn;
        }

        public void SetAutor(string autor)
        {
            Autor = autor;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public void SetISBN(long isbn)
        {
            ISBN = isbn;
        }

        public long GetISBN()
        {
            return ISBN;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = preco;
        }

        public override string ToString()
        {
            return base.ToString() + $", Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}
