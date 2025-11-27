using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "estoque.xml";

        if (File.Exists(caminhoArquivo))
        {
            try
            {
                XDocument doc = XDocument.Load(caminhoArquivo);
                var itemMouse = doc.Descendants("Item")
                                   .FirstOrDefault(x => x.Element("Nome")?.Value == "Mouse");

                if (itemMouse != null)
                {
                    itemMouse.Element("Quantidade").Value = "10";

                    doc.Save(caminhoArquivo);
                    Console.WriteLine("Quantidade do Mouse atualizada para 10 e salva com sucesso!");
                }
                else
                {
                    Console.WriteLine("O produto 'Mouse' não foi encontrado no XML.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar o XML: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("O arquivo 'estoque.xml' não foi encontrado na pasta do projeto.");
        }

        Console.ReadLine();
    }
}