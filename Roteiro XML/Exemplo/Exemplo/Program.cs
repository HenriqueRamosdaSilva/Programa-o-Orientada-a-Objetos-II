using System;
using System.Xml;
class Program
{
    static void Main()
    {
        using (XmlWriter writer = XmlWriter.Create("pedido.xml"))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("Pedido");
            writer.WriteStartElement("Item");
            writer.WriteAttributeString("codigo", "A123");
            writer.WriteAttributeString("quantidade", "10");
            writer.WriteElementString("Descricao", "Cabo HDMI");
            writer.WriteElementString("Preco", "49.90");
            writer.WriteEndElement(); // Fecha Item
            writer.WriteEndElement(); // Fecha Pedido
            writer.WriteEndDocument();
        }

        Console.WriteLine("✅ Arquivo XML 'produto.xml' criado comsucesso!");
    }
}
