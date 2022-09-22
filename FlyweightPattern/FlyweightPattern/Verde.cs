using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = " tartaruga dentro do casco, ";
            this.acao = "rodando no chao - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
