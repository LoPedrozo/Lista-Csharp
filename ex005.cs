using System;
public class Exercicio5
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int tabuada = 1;
        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            tabuada = numero * i;
            Console.WriteLine($"{numero} x {i} = {tabuada}");

        }


         
    }
}