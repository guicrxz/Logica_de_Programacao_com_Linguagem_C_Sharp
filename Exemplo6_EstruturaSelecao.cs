using System;

class Program
{   
    static void Main(string[] args)
    {
        int opcao;
        
        Console.WriteLine("1. Inclusão");
        Console.WriteLine("2. Alteração");
        Console.WriteLine("3. Exclusão");
        
        Console.Write("\nDigite sua opção:");
        opcao = int.Parse(Console.ReadLine());
        
        switch (opcao)      // Início do switch
        {
            case 1: Console.WriteLine("\nVocê escolheu inclusão");
            break;
            case 2: Console.WriteLine("\nVocê escolheu exclusão");
            break;
            case 3: Console.WriteLine("\nOpção Inválida");
            break;
            // fim do switch
        }
        Console.ReadKey();
    }
}