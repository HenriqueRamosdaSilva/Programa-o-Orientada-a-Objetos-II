using Newtonsoft.Json.Linq;

string json = @"
{
    'Servidor': 'Henriquecasa',
    'Porta': 1433,
    'Usuario': 'Henrique'
}";

JObject ser = JObject.Parse(json);


Console.WriteLine(ser["Servidor"]); 
Console.WriteLine(ser["Porta"]);
Console.WriteLine(ser["Usuario"]);
ser["Porta"] = 1111;
Console.WriteLine(ser.ToString());

