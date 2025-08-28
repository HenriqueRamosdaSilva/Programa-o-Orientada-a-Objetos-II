using System;
using BibliotecaConversao ; // Namespace da DLL
namespace AppTesteDLL
{
    class Program
    {
        static void Main()
        {
            var conver = new Conversor();
            Console.WriteLine("Farenhait " + conver.Celsius_Fahrenheit (100));
            Console.WriteLine("Quilometro " + conver.Metros_Quilometros(1000));
            Console.WriteLine("Indira o valor que deseja converter = ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Indira a taxa de cambio da moeda para qual deseja converter = ");
            double taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor convertido = " + conver.Converter_Moeda (valor, taxa));
        }
    }
}
