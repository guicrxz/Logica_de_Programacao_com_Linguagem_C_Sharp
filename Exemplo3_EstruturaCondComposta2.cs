using System;


class Program
{
    public static void Main(string[] args)
    {
        int N;
        Console.Write("Digite um número: ");
        N = int.Parse(Console.ReadLine());
        
        if ((N % 2) == 0)
            Console.WriteLine("\n{0} é par", N);
        else
            Console.WriteLine("\n{0} é ímpar", N);
            
        Console.ReadKey();
    }
}