using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public class Sedeznica : Vlecnica
    {
        public int SteviloSedezev { get; }

        public Sedeznica(string naziv, int kapacitetaNaUro, int steviloSedezev)
            : base(naziv, kapacitetaNaUro)
        {
            SteviloSedezev = steviloSedezev;
        }

        public override int IzracunajPretok()
        {
            return kapacitetaNaUro * SteviloSedezev;
        }
    }
}
