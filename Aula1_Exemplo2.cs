using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo2
{ //início namespace
	class Program
	{					//início class
	static void Main(string[]args)
		{	//início Main
		
			//Declaração de variáveis
		int a, b, total;
		
		//Atribuição de valores
		a = 20;
		b = 10;
		
		/*Concatenação de valores a serem exibidos na tela
		
		Cálculo da operação sendo realizado entre parênteses*/
		Console.WriteLine(a+"+"+b+"="+(a+b));
		
		// Resultado do cálculo da operação sendo atribuído em uma variável
		total = a-b;
		Console.WriteLine(a+"-"+b+"="+total);
		Console.WriteLine(a+"*"+b+"="+(a*b));
		Console.WriteLine(a+"/"+b+"="+(a/b));
		Console.WriteLine(a+"%"+b+"="+(a%b));
		Console.ReadKey(); //Instrução utilizada para dar uma pausa na visualização
		} //fim Main
		} //fim class
		} //fim namespace