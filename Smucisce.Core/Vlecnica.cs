using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{

    public abstract class Vlecnica
    {

        public string Naziv { get; }
        protected int kapacitetaNaUro;
        public bool Obratuje { get; private set; } = true;
        protected List<Proga> proge = new List<Proga>();

        public static int SteviloVlecnic { get; private set; }

        public IReadOnlyList<Proga> Proge => proge.AsReadOnly();

        //dogodka
        public event EventHandler<Proga> ProgaDodana;
        public event EventHandler<bool> StatusSpremenjen;

        protected Vlecnica(string naziv, int kapacitetaNaUro)
        {
            Naziv = naziv;
            this.kapacitetaNaUro = kapacitetaNaUro;
            SteviloVlecnic++;
        }

        public void DodajProgo(Proga p)
        {
            proge.Add(p);
            ProgaDodana?.Invoke(this, p);
        }
        public void Zazeni()
        {
            Obratuje = true;
            StatusSpremenjen?.Invoke(this, true);
        }

        public void Ustavi()
        {
            Obratuje = false;
            StatusSpremenjen?.Invoke(this, false);
        }
        public override string ToString()
        {
            string status = Obratuje ? "OBRATUJE" : "NE OBRATUJE";

            return $"{Naziv} | Kapaciteta: {kapacitetaNaUro}/h | {status}";
        }

        public abstract int IzracunajPretok();
    }
}
