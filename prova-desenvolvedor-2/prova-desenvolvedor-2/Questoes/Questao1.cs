namespace ConsoleApp.Questoes;

public static class Questao1
{
    public static void Executar()
    {
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }
        Console.WriteLine($"Resultado: {SOMA}");
    }
}
