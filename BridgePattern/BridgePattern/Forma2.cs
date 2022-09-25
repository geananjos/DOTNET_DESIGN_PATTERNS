using BridgePattern.Interfaces;

namespace BridgePattern
{
    public class Forma2 : IForma
    {
        public ICor Icor { get; set; }
        public string Descer()
        {
            return "U - " + Icor.Cor();
        }
    }
}
