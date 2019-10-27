using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg
{
    public class Wojownik :IPostac
    {
        private int _sila;

        public string Imie { get;  set; }
        public double PunktyZycia { get; set; }

        public Wojownik(string imie, int sila)
        {
            Imie = imie;
            PunktyZycia = 100;
            _sila = sila;
        }

        public Wojownik()
        {
            Imie = "Wiedzmin";
            PunktyZycia = 100;
            Random rand = new Random();
            _sila = rand.Next(6) + 1;
            _sila += rand.Next(6) + 1;
            _sila += rand.Next(6) + 1;
        }

        public double MocAtaku()
        {
            if (PunktyZycia < 5) return _sila;
            return _sila * PunktyZycia;
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
            return "Wojownik " + Imie + ", punkty zycia " + PunktyZycia + " % "
                + ", moc ataku " + MocAtaku();
        }


    }
}
