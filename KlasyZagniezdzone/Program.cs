using System;

namespace KlasyZagniezdzone
{
    class Program 
    {
        static void Main(string[] args)
        {
            Samochod sam = new Samochod();
            Console.WriteLine(sam.PobierzMoc());
            Console.ReadLine();
        }
    }

    class Samochod
    {
        private class Silnik
        {
            public Silnik(uint moc=500) //Klasa zagniezdzona ukrycie jej
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

}
