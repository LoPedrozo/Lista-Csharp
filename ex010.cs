using System;

public class Exercicio10
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite um número inteiro para calcular o fatorial:");
        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;
        string expressao = "";
        for (int i = n; i >= 1; i--)
        {
            fatorial *= i;
            expressao += i;
            if (i > 1)
                expressao += " x ";
        }
        Console.WriteLine($"{n}! = {expressao} = {fatorial}");
    }
}
