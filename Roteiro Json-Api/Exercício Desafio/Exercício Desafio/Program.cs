using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Reflection;
public class Program
{
    static async Task Main()
    {

        Console.WriteLine("\n=== Consultar pokeapi ===");
        Console.WriteLine("1 - Digite o nome do Pokemon");
        string Pokemonnome = Console.ReadLine().ToLower();
        await ConsultarPokeApi(Pokemonnome);
    }
    static async Task ConsultarPokeApi(string Pokemonnome)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{Pokemonnome}";
                string json = await client.GetStringAsync(url);
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(json);
                Console.WriteLine($"\nNome: {pokemon.name}");
                Console.WriteLine($"Altura: {pokemon.height}");
                Console.WriteLine($"Peso: {pokemon.weight}");
                Console.WriteLine("Tipos: " );
                foreach (var typeInfo in pokemon.types)
                {
                    Console.WriteLine($"- {typeInfo.type.name}");
                }


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nErro ao consultar a PokeAPI. Verifique o nome do Pokemon e tente novamente.");
            }
        }
    }
}

public class Pokemon
{
    public string name { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
    public List<TypeInfo> types { get; set; }
}
public class TypeInfo
{
    public TypeDetail type { get; set; }
}
public class TypeDetail
{
    public string name { get; set; }
}

