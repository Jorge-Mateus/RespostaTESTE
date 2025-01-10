using System;
using System.Linq;
using Newtonsoft.Json;

namespace Repostssa
{
    public class AnaliseDiario
    {
        static void Main(string[] args)
        {
            string json = @"{
            'faturamento': [1500, 2000, 1200, 1800, 2200, 0, 2500, 3000, 0, 1900, 1700, 2100, 2400, 2200, 2300, 2000, 0, 2500]
        }";

            var dados = JsonConvert.DeserializeObject<FaturamentoDados>(json);
            var faturamento = dados.Faturamento.Where(x => x > 0).ToArray(); // Ignora os dias sem faturamento

            var menorFaturamento = faturamento.Min();
            var maiorFaturamento = faturamento.Max();
            var mediaFaturamento = faturamento.Average();
            var diasAcimaDaMedia = faturamento.Count(x => x > mediaFaturamento);

            Console.WriteLine($"Menor faturamento: R${menorFaturamento}");
            Console.WriteLine($"Maior faturamento: R${maiorFaturamento}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
    }

    class FaturamentoDados
    {
        public decimal[] Faturamento { get; set; }
    }
}

