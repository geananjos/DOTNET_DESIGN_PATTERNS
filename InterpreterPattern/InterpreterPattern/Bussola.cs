using InterpreterPattern.Interfaces;

namespace InterpreterPattern
{
    public class Bussola : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Bussula ");
        }
    }
}
