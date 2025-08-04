using System;
public class Exercicio6
{
    public static void Executar(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota do aluno: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota do aluno: ");
        float nota3 = float.Parse(Console.ReadLine());
        float media = (nota1 + nota2 + nota3) / 3;
        if (media >= 7)
        {
        Console.WriteLine($"O aluno {nome} foi aprovado com média {media}.");
        }
        else if (media >= 5)
        {
            Console.WriteLine($"O aluno {nome} está em recuperação com média {media}.");
        }
        else
        {
            Console.WriteLine($"O aluno {nome} foi reprovado com média {media}.");
        }
        
    }
}