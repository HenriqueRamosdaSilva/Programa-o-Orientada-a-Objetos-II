using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string json = @"{ 'Nome': 'Henrique', 'Idade': 21, 'Curso': 'Sistemas de Informação'}";
        var Aluno = JsonConvert.DeserializeObject<Aluno>(json);
        Console.WriteLine($"Nome: {Aluno.Nome}, Idade: {Aluno.Idade}, Curso: {Aluno.Curso}");

    }
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
    }
}