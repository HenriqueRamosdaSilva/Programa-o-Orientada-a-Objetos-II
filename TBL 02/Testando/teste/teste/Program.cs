using System;

using Exercicio_01;

using System;
using Exercicio_01; // Importa a DLL (namespace onde está a exceção)

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarIdade(-5);      
            TestarIdade(130);     
            TestarIdade(30);     
        }

        static void TestarIdade(int idade)
        {
            try
            {
                Console.WriteLine($"\nTestando idade: {idade}");
                if (idade < 0 || idade > 120)
                    throw new IdadeInvalidaException($"Idade inválida: {idade}");
                Console.WriteLine("Idade válida! Cadastro permitido.");
            }
            catch (IdadeInvalidaException ex)
            {
                Console.WriteLine("⚠ Exceção capturada:");
                Console.WriteLine($"Mensagem: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

