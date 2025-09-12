using System;
using Execicio_05;

namespace Teste_EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Produto produto = new Produto("Notebook", 5);
                Console.WriteLine($"Produto: {produto.Nome}, Quantidade em estoque: {produto.Quantidade}");
                Console.Write("Digite a quantidade a vender: ");
                int quantidadeVenda = int.Parse(Console.ReadLine());

                produto.Vender(quantidadeVenda);
                Console.WriteLine($"Venda realizada com sucesso! Estoque restante: {produto.Quantidade}");
            }
            catch (EstoqueInsuficienteException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite apenas números inteiros.");
            }
        }
    }

    public class Produto
    {
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }

        public void Vender(int quantidadeVendida)
        {
            if (quantidadeVendida > Quantidade)
            {
                throw new EstoqueInsuficienteException($"Tentativa de vender {quantidadeVendida} unidades, mas o estoque disponível é apenas {Quantidade}.");
            }

            Quantidade -= quantidadeVendida;
        }
    }
}
