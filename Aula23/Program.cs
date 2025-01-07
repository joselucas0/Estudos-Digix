using System;

namespace Aula23{
    // Interface IGerente
    public interface IGerente
    {
        void Autorizar();
        bool ConcedeAumento();
        bool AutorizaLicenca(Empregado emp);
    }

    // Classe Pessoa
    public class Pessoa
    {
        protected string? sName;

        public Pessoa() { }

        public Pessoa(string name)
        {
            sName = name;
        }

        public void SetName(string name)
        {
            sName = name;
        }

        public string? GetName()
        {
            return sName;
        }
    }

    // Classe Empregado
    public class Empregado : Pessoa
    {
        protected double dSalario;
        protected double dSalarioMinimo = 240.0;
        protected int iLicencasPremioRecebidas;
        protected StatusLicenca LicencaStatus;

        public virtual double GetSalario()
        {
            return dSalario;
        }

        public int GetLicencasPremioRecebidas()
        {
            return iLicencasPremioRecebidas;
        }

        public void SetSalario(double salario)
        {
            dSalario = salario;
        }

        public void SetLicencasPremioRecebidas(int licencas)
        {
            iLicencasPremioRecebidas = licencas;
        }
    }

    // Classe Vendedor
    public class Vendedor : Empregado
    {
        private double dComissao;
        private RegiaoAtuacao Regiao;

        public override double GetSalario()
        {
            return dSalario + dComissao;
        }

        public void SetComissao(double comissao)
        {
            dComissao = comissao;
        }

        public void SetRegiao(RegiaoAtuacao regiao)
        {
            Regiao = regiao;
        }
    }

    // Classe GerenteVendas
    public class GerenteVendas : Empregado, IGerente
    {
        private string? sRegiao;

        public void Autorizar()
        {
            // Lógica de autorização
        }

        public bool ConcedeAumento()
        {
            // Lógica para conceder aumento
            return true;
        }

        public bool AutorizaLicenca(Empregado emp)
        {
            // Lógica para autorizar licença
            return true;
        }

        public override double GetSalario()
        {
            return dSalario * 1.2; // Exemplo de cálculo
        }
    }

    // Classe GerenteProducao
    public class GerenteProducao : Empregado, IGerente
    {
        public void Autorizar()
        {
            // Lógica de autorização
        }

        public bool ConcedeAumento()
        {
            // Lógica para conceder aumento
            return true;
        }

        public bool AutorizaLicenca(Empregado emp)
        {
            // Lógica para autorizar licença
            return true;
        }

        public override double GetSalario()
        {
            return dSalario * 1.15; // Exemplo de cálculo
        }
    }

    // Classe Empregados
    public class Empregados
    {
        private int iNumeroMaximo = 50;
        private List<Empregado> empregados = new List<Empregado>();
        private int iNumeroEmpregados = 0;

        public void Insere(Empregado emp)
        {
            if (iNumeroEmpregados < iNumeroMaximo)
            {
                empregados.Add(emp);
                iNumeroEmpregados++;
            }
        }

        public void Imprime()
        {
            foreach (var emp in empregados)
            {
                Console.WriteLine(emp.GetName());
            }
        }

        public void Write(string path)
        {
            // Lógica para salvar em arquivo
        }

        public void Read(string path)
        {
            // Lógica para ler de arquivo
        }

        public double CbFolhaPagamento()
        {
            double total = 0;
            foreach (var emp in empregados)
            {
                total += emp.GetSalario();
            }
            return total;
        }
    }

    // Classe de teste
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos
            Vendedor vendedor = new Vendedor();
            vendedor.SetName("Carlos");
            vendedor.SetSalario(3000);
            vendedor.SetComissao(500);
            vendedor.SetRegiao(RegiaoAtuacao.Sul);

            GerenteVendas gerenteVendas = new GerenteVendas();
            gerenteVendas.SetName("Ana");
            gerenteVendas.SetSalario(5000);

            GerenteProducao gerenteProducao = new GerenteProducao();
            gerenteProducao.SetName("João");
            gerenteProducao.SetSalario(4500);

            Empregado empregadoGenerico = new Empregado();
            empregadoGenerico.SetName("Maria");
            empregadoGenerico.SetSalario(2000);
            empregadoGenerico.SetLicencasPremioRecebidas(1);

            // Criando lista de empregados
            Empregados listaEmpregados = new Empregados();
            listaEmpregados.Insere(vendedor);
            listaEmpregados.Insere(gerenteVendas);
            listaEmpregados.Insere(gerenteProducao);
            listaEmpregados.Insere(empregadoGenerico);

            // Testando métodos
            Console.WriteLine("Lista de Empregados:");
            listaEmpregados.Imprime();

            Console.WriteLine("\nFolha de Pagamento Total: " + listaEmpregados.CbFolhaPagamento());

            Console.WriteLine("\nSalários Individuais:");
            Console.WriteLine($"{vendedor.GetName()} - Salário: {vendedor.GetSalario()}");
            Console.WriteLine($"{gerenteVendas.GetName()} - Salário: {gerenteVendas.GetSalario()}");
            Console.WriteLine($"{gerenteProducao.GetName()} - Salário: {gerenteProducao.GetSalario()}");
            Console.WriteLine($"{empregadoGenerico.GetName()} - Salário: {empregadoGenerico.GetSalario()}");

            Console.WriteLine("\nTestando licenças e aumentos:");
            Console.WriteLine($"{gerenteVendas.GetName()} autoriza licença: {gerenteVendas.AutorizaLicenca(empregadoGenerico)}");
            Console.WriteLine($"{gerenteProducao.GetName()} concede aumento: {gerenteProducao.ConcedeAumento()}");

            listaEmpregados.Imprime();
            }
        }

}