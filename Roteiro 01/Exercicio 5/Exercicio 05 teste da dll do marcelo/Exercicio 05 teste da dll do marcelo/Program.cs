using System;
using System.Linq;
using BibliotecaEstatistica;

namespace teste_da_dll_do_marcelo
{
    class Program
    {
        public double CalcularSoma(double[] numeros)
        {
            if (numeros == null)
                return 0;
            return numeros.Sum();
        }

        static void Main(string[] args)
        {
            double[] numeros = { 1.5, 2.5, 3.0, 4.0 };

            Program estatistica = new Program(); // instanciando a própria classe Program
            double soma = estatistica.CalcularSoma(numeros);

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
