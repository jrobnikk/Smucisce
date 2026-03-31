using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{
    public enum TezavnostProge
    {
        Lahka,
        Srednja,
        Tezka
    }

    public class Proga
    {
        public string Naziv { get; }
        public int Dolzina { get; }
        public TezavnostProge Tezavnost { get; }

        public Proga(string naziv, int dolzina, TezavnostProge tezavnost)
        {
            Naziv = naziv;
            Dolzina = dolzina;
            Tezavnost = tezavnost;
        }
        public override string ToString()
        {
            string status = Obratuje ? "DA" : "NE";
            return $"{Naziv} ({Tezavnost}, {Dolzina} m) {status}";
        }

        public bool Obratuje { get; private set; } = true;

        //dogodek
        public event EventHandler<bool> StatusSpremenjen;

        public void NastaviObratovanje(bool obratuje)
        {
            Obratuje = obratuje;
            StatusSpremenjen?.Invoke(this, obratuje);
        }

    }
}
