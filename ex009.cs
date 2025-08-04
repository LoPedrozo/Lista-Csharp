using System;

public class Exercicio9
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite um número:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) {


            Console.WriteLine($"{n} é par.");
        }
        else {

             Console.WriteLine($"{n} é ímpar.");

        }

     }
                
}

