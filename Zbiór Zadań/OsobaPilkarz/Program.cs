using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaPilkarz
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os = new Osoba("Jacek", "Przepiorka", "13-23-1992");
            os.WypiszInfo();
            Osoba os1 = new Student("Jacek", "Krzynowek", "22-32-1212", 1, 3, 102232);
            Osoba os2 = new Pilkarz("Krzysiek", "Bac", "22-33-1111", "Napastnik", "Barcelona", 2);
            Pilkarz pilkarz = new Pilkarz("Krzysiek", "Bac", "22-33-1111", "Napastnik", "Barcelona", 2);
            Student student = new Student("Karol", "bielawski", "22-33-1112", 1, 3, 102312);
            Ocena ocena = new Ocena("historia", "14-12-2018", 3);
            Ocena ocena2 = new Ocena("historia", "14-12-2018", 4);
            ((Student)os1).Dodaj(ocena);
            (student).Dodaj(ocena2);
            List<Osoba> studencik = new List<Osoba>();
            studencik.Add(student);
            foreach (var item in studencik)
            {
                Console.WriteLine(item);
            }
            ((Student)student).Dodaj(ocena);
            (student).Dodaj(ocena2);
            ((Student)student).Wyswietl();
            os1.WypiszInfo();   

            pilkarz.StrzelGola();
            pilkarz.WypiszInfo();
            
            Console.ReadLine();
        }
        class Osoba
        {
            protected string Imie { get; set; }
            protected string Nazwisko { get; set; }
            protected string DataUrodzenia { get; set; }

            public Osoba(string imie, string nazwisko, string dataurdzenia)
            {
                this.Imie = imie;
                this.Nazwisko = nazwisko;
                this.DataUrodzenia = dataurdzenia;
            }
            public Osoba()
            {
            }

            public virtual  void WypiszInfo()
            {
                
                Console.WriteLine($"Imie to : {Imie} , Nazwisko to {Nazwisko} , Data Urodzenia to {DataUrodzenia}");
            }
        }
        class Student : Osoba
        {
            public int Rok { get; set; }
            public int Grupa { get; set; }
            public int NrIndeksu { get; set; }
            public List<Ocena> oceny;

            public Student(string imie, string nazwisko, string dataurodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataurodzenia)
            {
                this.Rok = rok;
                this.Grupa = grupa;
                this.NrIndeksu = nrIndeksu;
                oceny = new List<Ocena>();
            }
            public void Dodaj(Ocena ocena)
            {
                oceny.Add(ocena);
            }
            public void Wyswietl()
            {
                foreach (var item in oceny)
                {
                    Console.WriteLine(item);
                }
            }

            public override  void WypiszInfo()
            {

                Console.WriteLine(Imie+ " + " + Nazwisko + " + " + DataUrodzenia+ " + " +Rok + " +   " + Grupa + " + " +NrIndeksu);
            }

        }
        public class Ocena
        {
            public string NazwaPrzedmiotu { get; set; }
            public string Data { get; set; }
            public double wartosc { get; set; }
            public Ocena(string nazwaPrzedmiotu, string data, double wartosc = 2)
            {
                this.NazwaPrzedmiotu = nazwaPrzedmiotu;
                this.Data = data;
                this.wartosc = wartosc;
            }

        }
        class Pilkarz : Osoba
        {
            public string pozycja { get; set; }
            public string klub { get; set; }
            public int liczbagoli = 0;

            public Pilkarz(string imie, string nazwisko, string dataurodzenia, string pozcyja, string  klub, int liczbagoli) : base(imie, nazwisko, dataurodzenia)
            {
                this.pozycja = pozcyja;
                this.klub = klub;
                this.liczbagoli = liczbagoli;
            }
            public override void WypiszInfo()
            {
                Console.WriteLine(Imie + " + " + Nazwisko + " + " + DataUrodzenia + " + " + pozycja + " +   " + klub+ " + " + liczbagoli);
            }
            public void StrzelGola()
            {
                liczbagoli++;   
            }
        
        }

    }
}
