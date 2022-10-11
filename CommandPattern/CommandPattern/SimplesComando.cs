namespace CommandPattern
{
    public class SimplesComando : ICommand
    {
        private string _solicitacao = string.Empty;

        public SimplesComando(string solicitacao)
        {
            _solicitacao = solicitacao;
        }

        public void Executar()
        {
            Console.WriteLine("Estou executando um Simples Comando de " + this._solicitacao);
        }
    }
}
