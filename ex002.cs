using System;
public class Exercicio2
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite o Primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        int soma = num1 + num2;
        Console.WriteLine($"A soma de {num1} + {num2} é igual a {soma}.");
    }
}