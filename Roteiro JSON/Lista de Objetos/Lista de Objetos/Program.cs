using System.IO;
using Newtonsoft.Json;

        var carros = new List<Carro>
        {
            new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020 },
            new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2019 },
            new Carro { Marca = "Byd", Modelo = "Não lembro", Ano = 2025 }
        };
string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
File.WriteAllText("carros.json", json);
Console.WriteLine("Arquivo salvo com sucesso!");

string jsonLido = File.ReadAllText("carros.json");
var carrosLidos = JsonConvert.DeserializeObject<List<Carro>>(jsonLido);
foreach (var carro in carrosLidos)
{
    Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Ano: {carro.Ano}");
}



class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}