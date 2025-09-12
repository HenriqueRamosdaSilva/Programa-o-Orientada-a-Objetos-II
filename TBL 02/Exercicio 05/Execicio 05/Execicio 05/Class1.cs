namespace Execicio_05
{
    public class EstoqueInsuficienteException : Exception
    {
        public EstoqueInsuficienteException() : base("Estoque insuficiente para realizar a venda.")
        {
        }
        public EstoqueInsuficienteException(string message) : base(message)
        {
        }
        public EstoqueInsuficienteException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
