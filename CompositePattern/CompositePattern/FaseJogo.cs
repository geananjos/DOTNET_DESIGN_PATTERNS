using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome)
        {

        
        }

        public override void Adicionar(ComponenteFase c)
        {
            Console.WriteLine("Nao e possivel adicionar a fase no jogo por aqui");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
        }

        public override void Remover(ComponenteFase c)
        {
            Console.WriteLine("Nao e possivel remover a fase no jogo por aqui");
        }
    }
}
