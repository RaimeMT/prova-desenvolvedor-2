using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Questão 1:");
        Questao1();

        Console.WriteLine("\nQuestão 2:");
        Questao2(21); // Pode mudar o número aqui

        Console.WriteLine("\nQuestão 3:");
        Questao3();

        Console.WriteLine("\nQuestão 4:");
        Questao4();

        Console.WriteLine("\nQuestão 5:");
        Questao5("exemplo"); // Pode mudar a string aqui
    }

    static void Questao1()
    {
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        Console.WriteLine($"Resultado: {SOMA}");
    }

    static void Questao2(int numero)
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

    static void Questao3()
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

        var dados = JsonSerializer.Deserialize<DadoFaturamento[]>(json);

        double menor = double.MaxValue;
        double maior = double.MinValue;
        double soma = 0;
        int diasValidos = 0;

        foreach (var item in dados)
        {
            if (item.valor > 0)
            {
                if (item.valor < menor) menor = item.valor;
                if (item.valor > maior) maior = item.valor;
                soma += item.valor;
                diasValidos++;
            }
        }

        double media = soma / diasValidos;
        int diasAcimaMedia = 0;

        foreach (var item in dados)
        {
            if (item.valor > media)
                diasAcimaMedia++;
        }

        Console.WriteLine($"Menor valor: {menor:F2}");
        Console.WriteLine($"Maior valor: {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }

    static void Questao4()
    {
        var faturamentos = new (string estado, double valor)[]
        {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        double total = 0;
        foreach (var f in faturamentos)
            total += f.valor;

        foreach (var f in faturamentos)
        {
            double percentual = (f.valor / total) * 100;
            Console.WriteLine($"{f.estado}: {percentual:F2}%");
        }
    }

    static void Questao5(string texto)
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

    public class DadoFaturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}
