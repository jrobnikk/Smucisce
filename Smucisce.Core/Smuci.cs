using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public class Smuci : Oprema
    {
        public bool ImaRobnike { get; }

        public Smuci(int dolzina, double cenaNaDan, string proizvajalec, bool imaRobnike)
            : base(dolzina, cenaNaDan, proizvajalec)
        {
            ImaRobnike = imaRobnike;
        }

        public override string Tip => "Smuči";
    }
}
