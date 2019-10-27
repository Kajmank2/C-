using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadankodziedziczenie
{
    class Czytelnik : Osoba
    {
        /*  public string[] Tablica = new string[10];*/ //deklaraacja tablicy
        Ksiazka ksiazka;

        public Czytelnik(string Imie, string Nazwisko, int Wiek, Ksiazka ksiazka) : base(Imie, Nazwisko, Wiek)
        {
            this.ksiazka = ksiazka;
        }
        public Czytelnik()
        {
            this.ksiazka = ksiazka;
        }
    }
}

