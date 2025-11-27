using System;
using System.Collections.Generic;
using System.IO; 
using System.Xml.Serialization; 

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Produto> listaDeProdutos = new List<Produto>
        {
            new Produto { Nome = "Notebook Gamer", Preco = 4500.00 },
            new Produto { Nome = "Mouse Sem Fio", Preco = 120.50 },
            new Produto { Nome = "Teclado Mecânico", Preco = 350.00 }
        };
        string caminhoArquivo = "produtos.xml";
        XmlSerializer serializador = new XmlSerializer(typeof(List<Produto>));

        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            serializador.Serialize(writer, listaDeProdutos);
        }

        Console.WriteLine($"Arquivo '{caminhoArquivo}' gerado com sucesso!\n");

        string conteudoXml = File.ReadAllText(caminhoArquivo);

        Console.WriteLine("--- Conteúdo do XML ---");
        Console.WriteLine(conteudoXml);

    }
}