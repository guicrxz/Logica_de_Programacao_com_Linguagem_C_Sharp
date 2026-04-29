using System;

    class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        
        while (num <= 20)
        {
            Console.Write("{0}", num);
            num = num + 1;  // ou num++
        }
        Console.ReadKey();
    }
}