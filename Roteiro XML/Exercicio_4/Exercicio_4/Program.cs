using System;
using System.Collections.Generic;
using System.Linq; 
using System.Net.Http; 
using System.Threading.Tasks; 
using System.Xml.Linq; 
public class Food
{
    public string Name { get; set; }
    public string Price { get; set; }
}
class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.w3schools.com/xml/simple.xml";

        Console.WriteLine("Iniciando requisição HTTP...");

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string xmlString = await client.GetStringAsync(url);
                Console.WriteLine("XML baixado com sucesso! Processando...\n");

                XDocument doc = XDocument.Parse(xmlString);

                List<Food> cardapio = doc.Descendants("food")
                                         .Select(item => new Food
                                         {
                                             Name = item.Element("name").Value,
                                             Price = item.Element("price").Value
                                         })
                                         .ToList();

                Console.WriteLine("CARDÁPIO DO W3SCHOOLS");
                foreach (var prato in cardapio)
                {
                    Console.WriteLine($"Prato: {prato.Name} | Preço: {prato.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }
        }

        Console.ReadLine();
    }
}