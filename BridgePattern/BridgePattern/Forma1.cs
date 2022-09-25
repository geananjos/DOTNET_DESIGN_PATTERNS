using BridgePattern.Interfaces;

namespace BridgePattern
{
    public class Forma1 : IForma
    {
        public ICor Icor { get; set; }
        public string Descer()
        {
            return "T - " + Icor.Cor();
        }
    }
}
