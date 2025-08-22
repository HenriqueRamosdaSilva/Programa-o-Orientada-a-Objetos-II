using System;
using System.Collections.Generic;

enum TipoPagamento
{
    Dinheiro,
    CartaoCredito,
    CartaoDebito,
    Pix
}
class Produtos
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public Produtos(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: R${Preco:F2}");
    }
}
class Carinho
{
    public List<Produtos> ListaProdutos { get; set; } = new List<Produtos>();
    public double Total { get; private set; }
    public void AdicionarProduto(Produtos produto)
    {
        ListaProdutos.Add(produto);
        Total += produto.Preco;
    }
    public void ExibirCarrinho()
    {
        Console.WriteLine("Carrinho de Compras:");
        foreach (var produto in ListaProdutos)
        {
            produto.ExibirDetalhes();
        }
        Console.WriteLine($"Total: R${Total:F2}");
    }
    public void Calcular_total()
    {
        Total = 0;
        foreach (var produto in ListaProdutos)
        {
            Total += produto.Preco;
        }
    }
}
class Program
{
    static void Main()
    {
        Produtos arroz = new Produtos("Arroz", 20.50);
        Produtos feijao = new Produtos("Feijão", 15.30);
        Produtos macarrao = new Produtos("Macarrão", 8.90);
        Carinho meuCarrinho = new Carinho();
        meuCarrinho.AdicionarProduto(arroz);
        meuCarrinho.AdicionarProduto(feijao);
        meuCarrinho.AdicionarProduto(macarrao);
        meuCarrinho.ExibirCarrinho();
        Console.WriteLine("Escolha o tipo de pagamento:");
        foreach (var tipo in Enum.GetValues(typeof(TipoPagamento)))
        {
            Console.WriteLine($"{(int)tipo} - {tipo}");
        }
        int escolha = int.Parse(Console.ReadLine());
        if (Enum.IsDefined(typeof(TipoPagamento), escolha))
        {
            TipoPagamento pagamento = (TipoPagamento)escolha;
            Console.WriteLine($"Você escolheu pagar com: {pagamento}");
        }
        else
        {
            Console.WriteLine("Opção de pagamento inválida.");
        }
        Console.WriteLine("Obrigado por sua compra!");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();



    }
}