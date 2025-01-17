using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula28
{
    public class ConsumirJsonparaTxt
{
    static async Task Main(string[] args)
    {
        // Url do arquivo json contendo informações sobre animes
        string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/";

        // Nome do arquivo TXT de Saída
        string nomeArquivo = "animes.txt";

        try
        {
            // HttpClient é uma classe que permite fazer requisições HTTP
            using (HttpClient cliente = new HttpClient())
            {
                // Faz a requisição get para obter o Json
                var response = await cliente.GetAsync(url);

                using (JsonDocument document = JsonDocument.Parse(response)){
                    var animeListe = document.RootElement.GetProperty("data");
                    SalvarTxt(animeListe, nomeArquivo);
                }
            }
        }
    }
}
}