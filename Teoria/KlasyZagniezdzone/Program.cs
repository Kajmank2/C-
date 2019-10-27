using System;

namespace KlasyZagniezdzone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Samochod sam = new Samochod();
            //Console.WriteLine(sam.PobierzMoc());
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.UstawWiek(12);
            czlowiek.UstawImie("Karol");
            Czlowiek czlowiek1 = new Czlowiek();
            czlowiek1.UstawWiek(13);
            czlowiek1.UstawImie("Wojtek");
            Console.WriteLine();
            Console.ReadLine();

            string[] tablica = new string[1];
            tablica[1] = czlowiek.PobierzImie();
            tablica[2] = czlowiek1.PobierzImie();

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    #region
    class Samochod
    {
        private class Silnik
        {
            public Silnik(uint moc = 500) //Klasa zagniezdzona ukrycie jej
            {

                this.Moc = moc;
                Console.WriteLine("Ja jestem z konnstruktora silnik");
            }
            public uint Moc;
        }
        public Samochod()
        {
            silnik = new Silnik(); // wywolanie silniku z Samochodu
            Console.WriteLine("ja jestem z kontruktora samochod");
        }

        public uint PobierzMoc()
        {
            return this.silnik.Moc;
        }
        private Silnik silnik; //musi byc priate tak jak klasa
    }
    #endregion
    class Czlowiek
    {

        private class Wiek
        {
            public int Lata;
            public Wiek(int wiek = 18)
            {
                this.Lata = wiek;
                Console.WriteLine("To ja wiek");
            }
        }
        private class Imie
        {
            public string Imionko;
            public Imie(string imie = "Domyślne Imie")
            {
                this.Imionko = imie;
                Console.WriteLine("Witam to twoje imie :" + imie);
            }
          
        }

        public Czlowiek()
        {
            imie = new Imie();
            wiek = new Wiek();
            Console.WriteLine("To ja czlowiek");
        }
        private Imie imie;
        private Wiek wiek;
        public int UstawWiek(int wiek)
        {
            return this.wiek.Lata = wiek;
        }
        public int PobierzWiek()
        {
            return this.wiek.Lata;
        }
        public void PokazWiek()
        {
            Console.WriteLine(PobierzWiek());
        }
        public string PobierzImie()
        {
            return this.imie.Imionko;
        }
        public  string UstawImie(string imie)
        {
            return this.imie.Imionko=imie;

        }
        public void PokazImie()
        {
            Console.WriteLine(PobierzImie());
        }

    }

}
