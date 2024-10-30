using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita o número de telefone no formato XX XXXXX-XXXX
        Console.Write("Por favor, insira o número de telefone no formato XX XXXXX-XXXX: ");
        string numeroTelefone = Console.ReadLine();

        // Extrai o DDD do número e verifica a localidade
        string ddd = ExtrairDDD(numeroTelefone);
        
        if (ddd != null)
        {
            string localidade = VerificaLocalidadeDDD(ddd);
            Console.WriteLine(localidade != null ? $"O DDD {ddd} corresponde à região: {localidade}" 
                                                 : "DDD não encontrado.");
        }
        else
        {
            Console.WriteLine("Formato de número inválido. Por favor, use o formato XX XXXXX-XXXX.");
        }
    }

    /// Extrai os dois primeiros caracteres do número como DDD.

    /// <parametro name="numeroTelefone">Número de telefone no formato XX XXXXX-XXXX.</param>
    /// <retorna>Retorna o DDD se o formato estiver correto, caso contrário null.</returns>
    static string ExtrairDDD(string numeroTelefone)
    {
        // Verifica se o número de telefone possui o formato correto
        if (numeroTelefone.Length >= 2 && numeroTelefone[2] == ' ')
        {
            return numeroTelefone.Substring(0, 2);
        }
        return null;
    }

    /// <summary>
    /// Verifica a localidade correspondente ao DDD.
    /// </summary>
    /// <param name="ddd">O DDD a ser verificado.</param>
    /// <returns>Retorna o nome da localidade correspondente ou null se o DDD não for encontrado.</returns>
    static string VerificaLocalidadeDDD(string ddd)
    {
        // Usa switch para verificar a localidade correspondente ao DDD
        switch (ddd)
        {
            // Paraná: DDDs de 41 a 46
            case "41":
            case "42":
            case "43":
            case "44":
            case "45":
            case "46":
                return "Paraná - PR";

            // Rio Grande do Sul: DDDs de 51 a 55
            case "51":
            case "53":
            case "54":
            case "55":
                return "Rio Grande do Sul - RS";

            // Goiás: DDDs 62 e 64
            case "62":
            case "64":
                return "Goiás - GO";

            // Mato Grosso: DDDs 65 e 66
            case "65":
            case "66":
                return "Mato Grosso - MT";

            // Mato Grosso do Sul: DDD 67
            case "67":
                return "Mato Grosso do Sul - MS";

            // Caso nenhum DDD corresponda
            default:
                return null;
        }
    }
}
