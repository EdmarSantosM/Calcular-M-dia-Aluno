
using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine();
        Console.Write("\nDigite seu nome: ");
        string nome = Console.ReadLine();
        System.Console.WriteLine("\n------------------------------------------------------------------");

        Console.Write("\nDigite a primeira nota:");
        float nota1 =(float.Parse(Console.ReadLine()));

        Console.Write("\nDigite a segunda  nota:");
        float nota2 = (float.Parse(Console.ReadLine()));

        Console.Write("\nDigite a terceira nota:");
        float nota3 =(float.Parse(Console.ReadLine()));

        Console.Write("\nDigite a quarta  nota:");
        float nota4 = (float.Parse(Console.ReadLine()));

        float resultado =  ((nota1 + nota2 + nota3 + nota4)/4);

        if( resultado > 7.5)
        {
            Console.WriteLine($"\nOlá {nome.ToUpper()},Parabéns! :) você foi aprovado com a média {resultado.ToString("N2")}");
        }
        else if (resultado > 5 && resultado < 7 )
        {
             Console.WriteLine($"\nOlá {nome.ToUpper()}, você está de recuperação :|, estude para o exame final, sua média foi {resultado.ToString("N2")}");
        }
        else
        {
             Console.WriteLine($"\nOlá {nome.ToUpper()}, Infelizmente  está  reprovado :(, sua média  foi {resultado.ToString("N2")}");
        }
            Console.WriteLine("\n----------------------------------------------------------------------------------------------- ");
            Console.WriteLine("\nPressione uma tecla para encerrar !");
            Console.ReadKey();

    }
}