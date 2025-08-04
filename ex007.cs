using System;

public class Exercicio7
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o quarto número:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o quinto número:");
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("O maior número é:");
        int maior = a;
        if (b > maior) maior = b;
        if (c > maior) maior = c;
        if (d > maior) maior = d;
        if (e > maior) maior = e;
        Console.WriteLine(maior);
        Console.WriteLine("O menor número é:");
        int menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;
        if (d < menor) menor = d;
        if (e < menor) menor = e;
        Console.WriteLine(menor);
        }
    
}

