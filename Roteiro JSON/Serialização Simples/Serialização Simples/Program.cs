using Newtonsoft.Json;
using System;
class Program
{
    static void Main()
    {
        var livro = new Livro
        {
            Titulo = "Json o Primeiro Progrema",
            Autor = "Henrique Ramos da Silva",
            Ano = 2025
        };
        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);


    }
}

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}