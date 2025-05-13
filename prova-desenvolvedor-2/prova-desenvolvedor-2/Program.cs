using System;
using ConsoleApp.Questoes;

class Program
{
    static void Main()
    {
        Console.WriteLine("Questão 1:");
        Questao1.Executar();

        Console.WriteLine("\nQuestão 2:");
        Questao2.Executar(21); // Você pode mudar o valor aqui

        Console.WriteLine("\nQuestão 3:");
        Questao3.Executar();

        Console.WriteLine("\nQuestão 4:");
        Questao4.Executar();

        Console.WriteLine("\nQuestão 5:");
        Questao5.Executar("exemplo"); // Você pode mudar o valor aqui
    }
}
