using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public class VlecnicaSidro : Vlecnica
    {
        public VlecnicaSidro(string naziv, int kapacitetaNaUro)
            : base(naziv, kapacitetaNaUro)
        {
        }

        public override int IzracunajPretok()
        {
            return kapacitetaNaUro;
        }
    }
}
