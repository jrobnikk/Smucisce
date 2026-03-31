using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smucisce.Core
{

    public interface ICenljiv
    {
        double CenaNaDan { get; }
    }

    //delegat za filtriranje
    public delegate bool FilterOpreme(Oprema o);

    public class Izposoja
    {
        private List<Oprema> prosta = new List<Oprema>();
        private List<Oprema> izposojena = new List<Oprema>();

        public static double SkupniPrihodek { get; private set; }

        //dogodka
        public event EventHandler<Oprema> OpremaIzposojena;
        public event EventHandler<Oprema> OpremaVrnjena;

        public IReadOnlyList<Oprema> ProstaOprema => prosta.AsReadOnly();

        public void DodajOprema(Oprema o)
        {
            prosta.Add(o);
        }

        public void Izposodi(Oprema o, int dni)
        {
            if (prosta.Remove(o))
            {
                izposojena.Add(o);
                SkupniPrihodek += o.CenaNaDan * dni;

                OpremaIzposojena?.Invoke(this, o);
            }
        }

        public void Vrni(Oprema o)
        {
            if (izposojena.Remove(o))
            {
                prosta.Add(o);
                OpremaVrnjena?.Invoke(this, o);
            }
        }

        //filtriranje
        public List<Oprema> Filtriraj(FilterOpreme filter)
        {
            return prosta.Where(o => filter(o)).ToList();
        }
    }
}
