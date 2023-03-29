using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "../../../Cidades.csv";
            string arquivoCSV = File.ReadAllText(caminhoArquivo);
            string[] listaDeCidades = arquivoCSV.Split(';');
            var dicionario = new Dictionary<string, string>();
            string estado;
            string opcao = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a forma de exibição: (cidade) para exibir em ordem alfabética (estado) para exibir por estados.");
                opcao = Console.ReadLine();
            } while (!opcao.ToLower().Equals("cidade") && !opcao.ToLower().Equals("estado"));

            for (int i = 4; i < listaDeCidades.Length - 4; i+=4)
            {
                estado = listaDeCidades[i+3] + i.ToString();
                dicionario.Add(estado, listaDeCidades[i + 2]);
            }
            var dicionarioOrdemAlfabetica = opcao.ToLower() == "cidade" ? dicionario.OrderBy(x => x.Value) : dicionario.OrderBy(x => x.Key);

            foreach (var cidadeEstado in dicionarioOrdemAlfabetica)
            {
                Console.WriteLine($"{cidadeEstado.Value}");
            }
        }
    }
}

//Desenvolva um programa em C# que leia o arquivo cidades.csv e dê a possibilidade de apresentar as cidades
//agrupadas pela primeira letra ou pelo estado que pertence.