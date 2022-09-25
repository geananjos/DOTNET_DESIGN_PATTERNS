using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Bridge
    {
        public IForma forma_solicitada { get; set; }

        public void ExibirQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(forma_solicitada.Descer());
        }
    }
}
