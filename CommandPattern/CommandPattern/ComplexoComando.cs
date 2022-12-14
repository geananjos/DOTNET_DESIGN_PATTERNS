namespace CommandPattern
{
    public class ComplexoComando : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexoComando(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Executar()
        {
            this._receiver.PrimeiroPedido(this._a);
            this._receiver.PrimeiroPedido(this._b);
        }
    }
}
