using System;


class Program
{
    public static void Main(string[] args)
    {
        int N, R;
        Console.Write("Digite um número: ");
        N = int.Parse(Console.ReadLine());
        
        R = N % 2;      //cálculo do resto da divisão de N por 2
        
        if (R == 0)
            Console.WriteLine("\n{0} é par", N);
        else
            Console.WriteLine("\n{0} é ímpar", N);
            
        Console.ReadKey();
    }
}