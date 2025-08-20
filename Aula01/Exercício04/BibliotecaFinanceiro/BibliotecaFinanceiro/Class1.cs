namespace BibliotecaFinanceiro
{
    public class Financeira
    {
        public double Juros_Compostos(double saldo_inicial, double taxa_juros, int tempo_rendendo)
        {
            return saldo_inicial * Math.Pow(1 + taxa_juros, tempo_rendendo);
        }

    }
}
