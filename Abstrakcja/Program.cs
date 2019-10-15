using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Pracownik("arek", "wlodarczyk",3000);
            Osoba osoba1 = new Student("Młody", "GIII", 2);

            Osoba[] osoby = new Osoba[4];
            osoby[0] = new Pracownik("arek", "wlodarczyk", 3000);
            osoby[1] =new Student("Młody", "GIII", 2);
            osoby[2] = new Pracownik("Andrzej", "Lidka", 2300);

            //for (int i = 0; i < osoby.Length; i++)
            //{
            //    if (osoby[i] != null)
            //    Console.WriteLine(osoby[i].Opis());
            //}
            Osoba.wypiszELementy(osoby);
            Console.ReadLine();
        }
    }

    abstract class Osoba // abstrakcja 
    {
        public static void wypiszELementy(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                if(osoby[i]!= null)
                    Console.WriteLine(osoby[i].Opis());
            }
        }
        public string Imie { get; protected set; }
        public string Nazwikso { get; protected set; }

        public Osoba()
        {
            this.Imie = "";
            this.Nazwikso = "";
        }
        public Osoba(string imie, string naziwsko)
        {
            this.Imie = imie;
            this.Nazwikso = naziwsko;
        }
        abstract public string Opis(); // dzieki temu jest wymagane i musza wszystkie metody miec opis
    }

    class Pracownik : Osoba // tą metode abstrakcyjna trzeba nadpisac ovveridem
    {
        public Pracownik() : base()
        {
            this.Wynagordzenie = 0;
        }
        public Pracownik(string imie, string nazwisko, double wynagrodzenie) : base(imie, nazwisko)
        {
            this.Wynagordzenie = wynagrodzenie;
        }
        public double Wynagordzenie { get; protected set; }
        override public string Opis()
        {
            return this.Imie + " " + this.Nazwikso + " " + Wynagordzenie;
        }
    }
    class Student : Osoba
    {
        public byte Semestr { get; protected set; }

        public Student() : base()
        {
            this.Semestr = 1;
        }
        public Student(string imie, string nazwisko, byte semestr) : base(imie, nazwisko)
        {
            this.Semestr = semestr;
        }
        override public string Opis()
        {
            return this.Imie + " " + this.Nazwikso + " " + Semestr;
        }
    }
}
