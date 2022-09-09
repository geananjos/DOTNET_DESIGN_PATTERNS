using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aereo");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rapida aerea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicoptero de ataque do exercito");
        }
    }
}
