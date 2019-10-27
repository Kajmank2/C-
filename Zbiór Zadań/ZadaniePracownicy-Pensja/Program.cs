using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_Obiektowek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontrakt kontrakt = new Kontrakt("Staz");
            Kontrakt kontrakt1 = new Kontrakt("Etat");
            kontrakt.Pensja("Staz");

            Pracownik prac = new Pracownik("Janusz", "Wolski", "Staz");
            Pracownik prac1 = new Pracownik("Karol", "Zaplakal", "Etat");
            Pracownik prac2 = new Pracownik("Tomasz", "TIKU");

            kontrakt.Swap<Kontrakt>(ref kontrakt, ref kontrakt1); // Zamiana kontraktów !o czym Si
            Console.WriteLine(kontrakt);

            List<Pracownik> part = new List<Pracownik>();
            {
                part.Add(new Pracownik("Krzysiek", "Fijałkowski", "Etat"));
                part.Add(new Pracownik("Krzysiek", "Ibisz", "Staz"));
                part.Add(prac);
                part.Add(prac1);
                part.Add(prac2);
            }
            foreach (Pracownik pracownik in part)
            {
                Console.WriteLine(pracownik);
            }
            Console.ReadKey();
        }
    }
    class Pracownik : Kontrakt
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }


        public Pracownik(string imie, string nazwisko, string penga = "Staz") : base(penga)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Penga = penga;
        }


        //public  void ZmienKontrakt(Kontrakt kontrakt) // do edycji 
        //{
        //    this.Kontrakt= kontrakt;
        //}
        public override string ToString()
        {
            return "Imie:  " + Imie + "|| Nazwisko : " + Nazwisko + "|| Kontrakt : " + Penga;
        }

    }
    class Kontrakt
    {
        public int Etat = 5000;
        public int Staz = 1000;
        public string Penga
        {
            get; set;
        }
        public void Swap<T>(ref T a, ref T b) //do kazdej metody trzeba robic oddzielnie
        {
            T tmp; // T - zmienna podmieniana
            tmp = a;
            a = b;
            b = tmp;
        }
        //public  void Swap<T>(ref T a, ref T b) //do kazdej metody trzeba robic oddzielnie
        //{
        //    T tmp; // T - zmienna podmieniana
        //    tmp = a;
        //    a = b;
        //    b = tmp;
        //}

        public void Pensja(string tmp)
        {
            switch (tmp)
            {
                case "Etat":
                    {
                        Console.WriteLine(Etat * 12);
                        break;
                    }
                case "Staz":
                    {
                        Console.WriteLine(Staz * 12);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Cos zle wprowadziles");
                        break;
                    }
            }
        }
        public Kontrakt(string penga)
        {
            this.Penga = penga;
            switch (penga)
            {
                case "Etat":
                    {
                        this.Etat = 5000;
                        //   Console.WriteLine("ooo jestes na Etacie twoje zarobki to : " + Etat);
                        break;
                    }
                case "Staz":
                    {
                        this.Staz = 1000;
                        //  Console.WriteLine("OOO jestes na Stazu twoje zarobki to : " + Staz);
                        break;
                    }
                default:
                    {
                        try
                        {
                            if (penga != "Etat" && penga != "Staz")
                                throw new KontraktException("Musisz podac tworzac użytkownika : Staz lub Etat || Innaczej cie nie przepuszcze");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            throw;
                        }

                        Console.WriteLine("Cos zle wprowadziles");
                        break;
                    }
            }
        }
    }

    class KontraktException : Exception
    {
        public KontraktException(string msg) : base(msg)
        {

        }
    }

}

