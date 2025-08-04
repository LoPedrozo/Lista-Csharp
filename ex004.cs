using System;
public class Exercicio4
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite uma temperatura em Celsius: ");
        float Celsius = float.Parse(Console.ReadLine());
        float Fahrenheit = (Celsius * 9 / 5) + 32;
        Console.WriteLine($"{Celsius}°C é igual a {Fahrenheit}°F.");
        
    }

}