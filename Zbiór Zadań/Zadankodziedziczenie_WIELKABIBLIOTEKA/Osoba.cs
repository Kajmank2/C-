using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadankodziedziczenie
{
    class Osoba
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }

        public Osoba( string Imie , string Nazwisko , int Wiek)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
        }
        public Osoba()
        {
            this.Imie = "Iga";
            this.Nazwisko = "Kitkapka";
            this.Wiek = 23;
        }
        public string Wypisz()
        {
            return this.Imie + this.Nazwisko + this.Wiek;
        }

        public static void wypiszELementy(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                if (osoby[i] != null)
                    Console.WriteLine(osoby[i].Wypisz());
            }
        }
    }
}
