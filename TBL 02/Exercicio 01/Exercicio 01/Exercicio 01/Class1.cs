namespace Exercicio_01
{
    public class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(string message) : base(message)
        {
        }
        public IdadeInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}

