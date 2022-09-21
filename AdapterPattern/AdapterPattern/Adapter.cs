using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : IAcao
    {
        Aviao aviao;

        public Adapter(Aviao novo_aviao)
        {
            this.aviao = novo_aviao;
        }
         
        public void Andar(string jogador)
        {
            this.aviao.Voar(jogador);
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
