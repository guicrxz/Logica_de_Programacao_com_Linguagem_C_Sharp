using System;

class Program
{
    static void Main(string[] args)
    {
        int q = 0, n;

        do
        {
            Console.WriteLine("\n\nPara sair digite (zero)");
            Console.Write("\nDigite um número: ");
            n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                q++; // incrementa o contador
            }

        } while (n != 0);

        Console.WriteLine("\nForam digitados {0} números inteiros", q);
        Console.WriteLine("\n\nTecle algo para continuar");
        Console.ReadKey();
    }
}