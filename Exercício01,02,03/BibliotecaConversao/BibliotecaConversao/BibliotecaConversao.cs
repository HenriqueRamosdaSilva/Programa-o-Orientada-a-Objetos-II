namespace BibliotecaConversao
{
    public class Conversor
    {
        public double Celsius_Fahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
        public double Metros_Quilometros(double metros)
        {
            return metros / 1000;
        }
        public double Converter_Moeda(double valor, double taxa_Cambio)
        {
            return valor * taxa_Cambio;
        }
    }
}

