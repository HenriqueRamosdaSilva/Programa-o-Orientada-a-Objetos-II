namespace Exercicio_04
{
    public class DivisaoPorZeroException : Exception
    {
        public DivisaoPorZeroException() : base("Divisão por zero não é permitida.")
        {
        }
        public DivisaoPorZeroException(string message) : base(message)
        {
        }
        public DivisaoPorZeroException(string message, Exception inner) : base(message, inner)
        {
        }


    }


   
}
