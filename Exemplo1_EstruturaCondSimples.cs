using System;

class Program
{   
    static void Main(string[] args)
    {
        int A, B, X;
        Console.WriteLine("Informe um valor para a variável A: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe um valor para a variável B: ");
        B = int.Parse(Console.ReadLine());
        
        X = A + B;
        
        if (X > 0)
        Console.WriteLine("\nO resultado da soma é {0}, sendo maior que 0 (zero)", X);
        Console.ReadKey();
    }
}