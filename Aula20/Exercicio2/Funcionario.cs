using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Funcionario
{
    public string? Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public string? Cpf { get; set; }
    public Endereco? Enderecos { get; set; }

    public string? GetNome()
    {
        return Nome;
    }

    public DateTime? GetNascimento()
    {
        return Nascimento;
    }

    public string? GetCpf()
    {
        return Cpf;
    }

    public Endereco? GetEnderecos()
    {
        return Enderecos;
    }

    public int DiasParaReceberSalario()
    {
        DateTime hoje = DateTime.Now;
        DateTime proximoPagamento;

        if (hoje.Day <= 5)
        {
            // Se o dia atual é antes ou igual a 5, o pagamento é neste mês
            proximoPagamento = new DateTime(hoje.Year, hoje.Month, 5);
        }
        else
        {
            // Caso contrário, o pagamento será no próximo mês
            proximoPagamento = new DateTime(hoje.Year, hoje.Month, 5).AddMonths(1);
        }

        TimeSpan diferenca = proximoPagamento - hoje;
        return diferenca.Days;
    }
}
}