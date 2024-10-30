using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita a senha e verifica se corresponde a "Digix"
        Console.WriteLine("Bem-vindo ao sistema Digix!");
        Console.Write("Por favor, insira sua senha: ");
        string senha = Console.ReadLine();

        if (VerificaSenha(senha)) //se a senha é true, entra no if
        {
            Console.WriteLine("Acesso autorizado. Bem-vindo!");
        }
        else
        {
            Console.WriteLine("Acesso negado. Senha incorreta.");
        }
    }


    /// Verifica se a senha fornecida corresponde à senha correta.
  
    /// <parametro ="senha">Senha inserida pelo usuário.</param>
    /// <retornos>Retorna true se a senha estiver correta, caso contrário false.</returns>
    static bool VerificaSenha(string senha)
    {
        const string senhaCorreta = "Digix";
        return senha == senhaCorreta;
    }
}
