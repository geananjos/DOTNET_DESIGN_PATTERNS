using InterpreterPattern.Interfaces;

namespace InterpreterPattern
{
    public class ArcoFlecha : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Arco e Flecha ");
        }
    }
}
