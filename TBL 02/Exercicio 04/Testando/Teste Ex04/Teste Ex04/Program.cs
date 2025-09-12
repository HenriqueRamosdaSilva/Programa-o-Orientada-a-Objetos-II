using System;
using Exercicio_04;

namespace Teste_Ex04
{
    class Program
    {
        static void Main(string[] args) {
            try
            {
                Console.Write("Digite o numerador: ");
                int numerador = int.Parse(Console.ReadLine());
                Console.Write("Digite o denominador: ");
                int denominador = int.Parse(Console.ReadLine());
                if (denominador == 0)
                {
                    throw new DivisaoPorZeroException();
                }
                int resultado = numerador / denominador;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivisaoPorZeroException ex)
            {
                Console.WriteLine($"Erro personalizado: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro de formato: Por favor, digite apenas números inteiros.");
            }
        }
    }

}
