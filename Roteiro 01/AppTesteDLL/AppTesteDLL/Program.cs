using System;
using MinhaBiblioteca; // Namespace da DLL
namespace AppTesteDLL
{
    class Program
    {
        static void Main()
        {
            var calc = new Calculadora();
            Console.WriteLine("Soma: " + calc.Somar(5, 3));
            Console.WriteLine("Multiplicação: " +
           calc.Multiplicar(4, 2));
        }
    }
}
