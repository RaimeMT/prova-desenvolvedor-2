using ConsoleApp.Models;
using System.Text.Json;
using static Program;

namespace ConsoleApp.Questoes;

public static class Questao3
{
    public static void Executar()
    {
        string json = @"[
            {""dia"": 1, ""valor"": 22174.1664},
            {""dia"": 2, ""valor"": 24537.6698},
            {""dia"": 3, ""valor"": 26139.6134},
            {""dia"": 4, ""valor"": 0.0},
            {""dia"": 5, ""valor"": 0.0},
            {""dia"": 6, ""valor"": 26742.6612},
            {""dia"": 7, ""valor"": 0.0},
            {""dia"": 8, ""valor"": 42889.2258},
            {""dia"": 9, ""valor"": 46251.174},
            {""dia"": 10, ""valor"": 11191.4722}
        ]";

        var dados = JsonSerializer.Deserialize<List<DadoFaturamento>>(json);

        var dadosValidos = dados.Where(x => x.valor > 0).ToList();

        double menor = dadosValidos.Min(x => x.valor);
        double maior = dadosValidos.Max(x => x.valor);
        double media = dadosValidos.Average(x => x.valor);
        int diasAcimaMedia = dadosValidos.Count(x => x.valor > media);

        Console.WriteLine($"Menor valor: {menor:F2}");
        Console.WriteLine($"Maior valor: {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}
