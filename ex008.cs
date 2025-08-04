using System;

public class Exercicio8
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite um número inicial para a contagem regressiva:");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Contagem regressiva:");
        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}

