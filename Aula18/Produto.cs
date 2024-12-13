namespace Aula18
{
    public class Produto
    {
        // Atributos privados
        private string? _nome;
        private double _preco;
        private int _quantidade;

        // Construtor padrão
        public Produto()
        {
        }

        // Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            Nome = nome; // Usa a propriedade com validação
            Preco = preco;
        }

        // Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade; // Usa a propriedade com validação
        }

        // Propriedades com lógica de validação
        public string Nome
        {
            get => _nome ?? string.Empty; // Retorna uma string vazia se _nome for null
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome deve ter pelo menos dois caracteres.");
                }
            }
        }

        public double Preco
        {
            get => _preco;
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
                else
                {
                    throw new ArgumentException("O preço deve ser maior que zero.");
                }
            }
        }

        public int Quantidade
        {
            get => _quantidade;
            set
            {
                if (value >= 0)
                {
                    _quantidade = value;
                }
                else
                {
                    throw new ArgumentException("A quantidade não pode ser negativa.");
                }
            }
        }

        // Método para calcular o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        // Método ToString para exibir informações do produto
        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco:F2}, Quantidade: {Quantidade}";
        }
    }

   
}
