namespace Banco
{
    public class ContaBancaria
    {
        // Campos privados
        private int _numero;           // Número da conta
        private string _titular;       // Nome do titular
        private double _saldo;         // Saldo da conta

        private const double TAXA_SAQUE = 5.00; // Taxa fixa para saque

        // Propriedade para número da conta (só leitura)
        public int Numero
        {
            get { return _numero; }
        }

        // Propriedade para titular (pode ser alterado)
        public string Titular
        {
            get { return _titular; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titular = value;
                }
                else
                {
                    throw new ArgumentException("O nome do titular não pode ser vazio.");
                }
            }
        }

        // Propriedade para saldo (somente leitura, protegido)
        public double Saldo
        {
            get { return _saldo; }
        }

        // Construtor
        public ContaBancaria(int numero, string titular, double depositoInicial = 0.0)
        {
            _numero = numero;
            _titular = titular;
            _saldo = depositoInicial;
        }

        // Método para depósito
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
            else
            {
                throw new ArgumentException("O valor do depósito deve ser positivo.");
            }
        }

        // Método para saque
        public void Sacar(double valor)
        {
            double valorTotal = valor + TAXA_SAQUE;
            if (valorTotal <= _saldo)
            {
                _saldo -= valorTotal;
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            }
        }

        // Sobrescrevendo ToString para exibir os dados da conta
        public override string ToString()
        {
            return $"Conta: {_numero}, Titular: {_titular}, Saldo: {_saldo:F2}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Cadastro da conta
            ContaBancaria conta = new ContaBancaria(12345, "José Lucas");

            // Exibe dados iniciais da conta
            System.Console.WriteLine(conta);

            // Realizar depósito
            conta.Depositar(200.00);
            System.Console.WriteLine(conta); // Exibe dados após o depósito

            // Realizar saque
            conta.Sacar(100.00);
            System.Console.WriteLine(conta); // Exibe dados após o saque

            // Alterar titular
            conta.Titular = "Maria Clara";
            System.Console.WriteLine(conta); // Exibe dados após alteração do titular
        }
    }
}
