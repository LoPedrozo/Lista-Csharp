using System;
public class Exercicio3
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");

        }
        else
        {
            Console.WriteLine("Você é maior de idade.");
        }
       
    }
}