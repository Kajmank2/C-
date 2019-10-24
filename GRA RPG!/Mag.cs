using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg
{
    public class Mag : IPostac
    {
        private int _punkty_magii;
        private int _sila;

        public string Imie { get;  private set; }
        public double PunktyZycia { get; private set; }

        public Mag(string imie, int sila, int punkty_magii)
        {
            Imie = imie;
            PunktyZycia = 100;
            _punkty_magii = punkty_magii;
            _sila = sila;
        }

        public Mag()
        {
            Imie = "Xardas";
            PunktyZycia = 100;
            Random rand = new Random();
            _sila = rand.Next(6) + 1;
            _punkty_magii = rand.Next(6) + 1;
            _punkty_magii += rand.Next(6) + 1;
        }

        public double MocAtaku()
        {
            return (_punkty_magii + _sila) * PunktyZycia;
        }

        public double ZmienZywotnosc(double x)
        {
            PunktyZycia += x;
            if (PunktyZycia < 0) PunktyZycia = 0;
            if (PunktyZycia > 100) PunktyZycia = 100;
            return PunktyZycia;
        }

        public override string ToString()
        {
            return "Mag " + Imie + ", punkty zycia " + PunktyZycia + " % "
                + ", moc ataku " + MocAtaku();
        }
    }
}
