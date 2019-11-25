using System;

namespace AplikacjaSklep
{
    class Program
    {
        static void Main(string[] args)
        {
            Cena cenapomidora = new Cena(12, 99);
            Obiekty pomidor = new Owoc(false, 232, "podmidor", "Warzywko", cenapomidora);
           // Obiekty ogoek = new Warzywko("Ogorek", "Warzywko", true, 231, cena: 32, 21);
            Warzywniak warzywniak = new Warzywniak("U Basieniki");
            Obiekty ananas = new Owoc(true, 12, "Ananas", "Lisciasty",cenapomidora );

            warzywniak.Dodaj(pomidor);
            warzywniak.Dodaj(ananas);
            Console.WriteLine(ananas);
            warzywniak.EquealCena(cenapomidora, cenapomidora);
            Console.WriteLine(warzywniak);
            Console.ReadKey();
        }
    }
}
