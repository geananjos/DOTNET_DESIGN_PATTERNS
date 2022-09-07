using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terran Criada com sucesso");
            
            var revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();
            
            var energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
