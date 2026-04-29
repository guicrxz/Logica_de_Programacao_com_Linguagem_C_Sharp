using System;

    class Program
{
    static void Main(string[] args)
    {
        int n;
        
        Console.Write("Digite um número: ");
        n = int.Parse(Console.ReadLine());
        
        while (n < 20)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}", n);
            }
            n++;
        }
        Console.ReadKey();
    }
}