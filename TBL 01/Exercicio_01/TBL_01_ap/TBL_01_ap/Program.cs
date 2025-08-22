using System;
using System.Collections.Generic;

class Clientes
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}");
    }
}

class Produtos
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: {Preco:C}");
    }
}
class Pedidos
{
    public int Id { get; set; }
    public Clientes Cliente { get; set; }
    public List<Produtos> Produtos { get; set; } = new List<Produtos>();
    public void Exibir()
    {
        Console.WriteLine($"Pedido ID: {Id}, Cliente: {Cliente.Nome}");
        foreach (var produto in Produtos)
        {
            produto.Exibir();
        }
    }
}

class Program
{
    static void Main()
    {
        Produtos produto1 = new Produtos { Nome = "Laptop", Preco = 1500.00m };
        Produtos produto2 = new Produtos { Nome = "Smartphone", Preco = 800.00m };
        Clientes cliente1 = new Clientes { Nome = "Henrique", Email = "hrique@gmail.com"};
        Clientes cliente2 = new Clientes { Nome = "Maria", Email = "Maria@gmail.com" };
        Pedidos pedido1 = new Pedidos { Id = 1, Cliente = cliente1 };
        pedido1.Produtos.Add(produto1);
        Pedidos pedido2 = new Pedidos { Id = 2, Cliente = cliente2 };
        pedido2.Produtos.Add(produto2);
        pedido1.Exibir();
        pedido2.Exibir();



    }

}
    