using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadankodziedziczenie
{
    class Pracownik : Osoba
    {
        public string Pozycja { get; set; }

       public Pracownik(string Imie, string Nazwisko, int Wiek, string Pozycja) : base(Imie, Nazwisko, Wiek)
        {
            this.Pozycja = Pozycja;
        }
       public Pracownik()
        {
            this.Pozycja = " Kierownik ";
        }
        new public static void wypiszELementy(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                if (osoby[i] != null)
                    Console.WriteLine(osoby[i]);
            }
        }
    }
}
