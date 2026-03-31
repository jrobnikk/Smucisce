using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public abstract class Oprema : ICenljiv
    {
        // skupne lastnosti
        public int Dolzina { get; }
        public double CenaNaDan { get; }
        public string Proizvajalec { get; }

        protected Oprema(int dolzina, double cenaNaDan, string proizvajalec)
        {
            Dolzina = dolzina;
            CenaNaDan = cenaNaDan;
            Proizvajalec = proizvajalec;
        }

        public abstract string Tip { get; }

        public override string ToString()
        {
            return $"{Tip} - {Proizvajalec} ({Dolzina} cm)";
        }
    }
}
