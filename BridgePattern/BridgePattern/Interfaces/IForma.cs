using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interfaces
{
    public interface IForma
    {
        string Descer();
        ICor Icor { get; set; }
    }
}
