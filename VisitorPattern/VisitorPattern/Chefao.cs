using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Chefao : IJogo
    {
        public string NomeChefao { get; set; }
        public int PontoVida { get; set; }

        public void Visitante(IVisitor visitante)
        {
            visitante.Identificar(this);
        }
    }
}
