using System;

namespace Zadankodziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Autor autor = new Autor("Karol Kami", 23);
            //Console.WriteLine(autor.Imie + autor.Wiek);

            //Pisarz pisarz = new Pisarz("Andrzej", 24, "QWO FADIS");
            //Console.WriteLine(pisarz.Imie + pisarz.Book);

            Osoba osoba = new Osoba("Andrze", "Szklarz", 32);
            osoba.Wypisz();
            Osoba osoba1 = new Osoba("Andrzej", "Szklarz1", 32);
            osoba1.Wypisz();
            Osoba osoba2 = new Osoba("Theresa", "Rebecka", 44);
            Ksiazka ksiazka = new Ksiazka("Pies ktory jezdzil koleja ", DateTime.Now, osoba1);
            Ksiazka ksiazka1 = new Ksiazka("Pies ktory jezdzil koleja ", DateTime.Now, osoba);
            Ksiazka ksiazka2 = new Ksiazka("dziewczyna z okladki", DateTime.UtcNow, osoba2);
            Ksiazka[] ksiazki = new Ksiazka[34];
            ksiazki[0] = ksiazka;
            ksiazki[1] = ksiazka1;
            ksiazki[2] = ksiazka2;
            ksiazki[3] = new Ksiazka("Alfons Hitliu");
            Ksiazka.wypiszKsiazki(ksiazki);
            Czytelnik czytelnik = new Czytelnik("Jan", "Kowalski", 32,ksiazka1);
            Czytelnik Iga = new Czytelnik();
            Console.WriteLine(Iga.Wypisz());
            czytelnik.Wypisz();
            Osoba[] osoby = new Osoba[4];
            osoby[0] = new Pracownik("arek", "wlodarczyk", 3000,"Piesek");
            osoby[1] = new Czytelnik("Karol","Kot",23,ksiazka);
            osoby[2] = new Czytelnik("Andrzej","Szklarz",23,ksiazka1);
            osoby[3] = new Czytelnik("Iga", "Hakobjan", 21, ksiazka2);
            Osoba.wypiszELementy(osoby);
            //Czytelnik czytelnik2 = new Czytelnik("Jan2", "Kowalski2", 321);
            //Czytelnik czytelnik3 = new Czytelnik("Jan3", "Kowalski3", 3211);
            //czytelnik.PrintKsiazkiArray(new string[,] { { "pijem", "Katus" } ,{"siema","niema" } });
            Console.ReadLine();
        }
    }
}
