using System;

    class Program
{
    static void Main(string[] args)
    {
        int A;
        
        do
        {
            Console.Write("Digite um número: ");
            A = int.Parse(Console.ReadLine());
            
            if (A != 0)
                Console.WriteLine("Dobro de {0} = {1} \n", A, (A * 2));
        } while (A !=0);
        
        Console.ReadKey();
    }
}