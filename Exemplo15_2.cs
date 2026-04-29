using System;

class Program
{
    static void Main(string[] args)
    {
        double soma = 0, n;

        do
        {
            Console.WriteLine("Para sair digite (zero)");
            Console.Write("\nDigite um número: ");
            n = double.Parse(Console.ReadLine());

            soma += n; // ou soma = soma + n

            Console.WriteLine("\nAcúmulo da soma = {0}", soma);

        } while (n != 0);

        Console.WriteLine("\n\nTecle algo para continuar");
        Console.ReadKey();
    }
}
}