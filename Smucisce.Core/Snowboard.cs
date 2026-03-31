using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public class Snowboard : Oprema
    {
        public string TipDeske { get; }

        public Snowboard(int dolzina, double cenaNaDan, string proizvajalec, string tipDeske)
            : base(dolzina, cenaNaDan, proizvajalec)
        {
            TipDeske = tipDeske;
        }

        public override string Tip => "Snowboard";
    }
}
