using System;

namespace Aula1_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definição da constante pi
            const double pi = 3.14159265358979323846;

            // Declaração de variável
            double raio = 10;
            double area;

            Console.WriteLine("Cálculo da área de um Círculo \n");
            Console.WriteLine("Fórmula: area = pi * raio² \n");

            // Math.Pow: exponenciação
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área = {0}", area);
            Console.WriteLine("Área = {0:N}", area);
            Console.WriteLine("Área = {0:N5}", area);

            Console.ReadKey();
        }
    }
}