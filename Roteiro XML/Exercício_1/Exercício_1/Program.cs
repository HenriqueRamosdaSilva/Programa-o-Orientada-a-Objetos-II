using System;
using System.IO;
using System.Xml.Serialization;
[XmlRoot("Aluno")]
public class Aluno
{
    [XmlElement("Nome")]
    public string Nome { get; set; }
    [XmlElement("Curso")]
    public string Curso { get; set; }
}

class Program
{
    static void Main()
    {
        var turma = new Turma
        {
            Alunos = new List<Aluno>
             {
                new Aluno { Nome = "Maria", Curso = "Sistemas de Informação" },
                new Aluno { Nome = "João", Curso = "Engenharia de Software" }             }
        };


        XmlSerializer serializer = new XmlSerializer(typeof(Turma));
        using (StreamWriter writer = new StreamWriter("turma.xml"))
        {
            serializer.Serialize(writer, turma);
        }

        using (StreamReader reader = new StreamReader("turma.xml"))
        {
            Turma turmaDeserializada = (Turma)serializer.Deserialize(reader);

            foreach (var aluno in turmaDeserializada.Alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Curso: {aluno.Curso}");
                Console.WriteLine();
            }
        }

    }
}
[XmlRoot("Turma")]
public class Turma
{
    [XmlArray("Alunos")]
    [XmlArrayItem("Aluno")]
    public List<Aluno> Alunos { get; set; }
}
