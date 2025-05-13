namespace ConsoleApp.Questoes;

public static class Questao5
{
    public static void Executar(string texto)
    {
        char[] invertido = new char[texto.Length];
        for (int i = texto.Length - 1, j = 0; i >= 0; i--, j++)
        {
            invertido[j] = texto[i];
        }
        string resultado = new string(invertido);
        Console.WriteLine($"Texto original: {texto}");
        Console.WriteLine($"Texto invertido: {resultado}");
    }
}
