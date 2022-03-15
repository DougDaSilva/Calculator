using System;
using System.Globalization;
using SimpleCalculator.Entities;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------CALCULADORA----------------");
            Console.WriteLine();
            Console.Write("Digite uma das quatro operações (+) , (-) , (*) ou (/): ");           
            char sinal = char.Parse(Console.ReadLine());
            if (sinal == '/')
            {
                Console.WriteLine("ATENÇÃO! Na divisão digite apenas 2 números!");
            }
            Console.Write("Quantos números você deseja calcular? ");           
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (sinal == '+')
            {
                Console.WriteLine("O resultado é: " + Calculator.Sum(vect), CultureInfo.InvariantCulture);
            }
            else if(sinal == '-')
            {
                Console.WriteLine("O resultado é: " + Calculator.Subtraction(vect), CultureInfo.InvariantCulture);
            }
            else if (sinal == '*')
            {
                Console.WriteLine("O resultado é: " + Calculator.Multiplication(vect).ToString("F4", CultureInfo.InvariantCulture));
            }
            
            else
            {
                Console.WriteLine("Operação inválida!");
            }
           
            
        }
    }
}
