namespace ConsoleApp.Questoes;

public static class Questao4
{
    public static void Executar()
    {
        var faturamentos = new (string Estado, double Valor)[]
        {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        double total = faturamentos.Sum(f => f.Valor);

        foreach (var f in faturamentos)
        {
            double percentual = (f.Valor / total) * 100;
            Console.WriteLine($"{f.Estado}: {percentual:F2}%");
        }
    }
}
