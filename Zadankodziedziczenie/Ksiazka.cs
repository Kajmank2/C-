using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadankodziedziczenie
{
    class Ksiazka : Osoba
    {
        string Tytul { get; set; }
        Osoba osoba;
        DateTime DataWydania { get; set; }

        public Ksiazka(string Tytul, DateTime DataWydania,Osoba osoba )
        {
            this.osoba = osoba;
            this.Tytul = Tytul;
            this.DataWydania = DataWydania;
        }
        public Ksiazka(string Tytul)
        {
            this.Tytul = Tytul; 

        }
    new public  string Wypisz()
        {
            return this.Tytul + " " + this.DataWydania + " " + this.osoba;
        }
        public static void wypiszKsiazki(Ksiazka[] ksiazki)
        {
            for (int i = 0; i < ksiazki.Length; i++)
            {
                if (ksiazki[i] != null)
                    Console.WriteLine(ksiazki[i].Wypisz());
            }
        }
    }
}
