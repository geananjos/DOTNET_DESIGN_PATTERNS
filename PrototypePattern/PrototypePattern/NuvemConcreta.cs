using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class NuvemConcreta : NuvemMolde
    {
        private string cor_preenchimento { get; set; }
        private string cor_contorno { get; set; }

        public NuvemConcreta(string preenchimento, string contorno)
        {
            this.cor_preenchimento = preenchimento;
            this.cor_contorno = contorno;
        }

        public override NuvemMolde Clone()
        {
            Console.WriteLine($@"A nuvem clonada tem contorno {this.cor_contorno} e preenchimento {this.cor_preenchimento}");
            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}
