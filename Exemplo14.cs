using System;

class Program
{
    static void Main(string[] args)
    {
        int op, n;

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Par/ímpar");
            Console.WriteLine("2 - Decrescente até zero");
            Console.WriteLine("3 - Sair");
            Console.Write("\nInforme a opção desejada: ");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Digite um número: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n + " é " + (n % 2 == 0 ? "par" : "ímpar"));
                    break;

                case 2:
                    Console.Write("Digite um número: ");
                    n = int.Parse(Console.ReadLine());
                    while (n >= 0)
                    {
                        Console.Write(n + " ");
                        n--;
                    }
                    Console.WriteLine("(zero)");
                    break;

                case 3:
                    Console.WriteLine("Fim da execução do programa");
                    break;

                default:
                    Console.WriteLine("Opção inválida - tente novamente");
                    break;
            }

            Console.WriteLine("\nTecle algo para continuar...");
            Console.ReadKey();

        } while (op != 3);
    }
}