namespace ConsoleApp.Questoes;

public static class Questao2
{
    public static void Executar(int numero)
    {
        int a = 0, b = 1;
        bool pertence = false;

        while (a <= numero)
        {
            if (a == numero)
            {
                pertence = true;
                break;
            }
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"O número {numero} {(pertence ? "pertence" : "não pertence")} à sequência de Fibonacci.");
    }
}
