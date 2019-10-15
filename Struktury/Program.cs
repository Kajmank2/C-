using System;

namespace Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            //struktury uzywamy kiedy jest tego duzo , kiedy nie uzywamy metod
            KsiazkaAdresowa ka; // automatycznie rezerwuje 
            KsiazkaAdresowa2 ka2 = new KsiazkaAdresowa2();
            KsiazkaAdresowa h = new KsiazkaAdresowa("karol", "Kot", "123456789");
            Console.WriteLine(h.Nazwisko);
            ka.Imie = "arek";
            ka.Nazwisko = "fjak";
            ka.Telefon = " 654 443 543";

            ka2.Imie = "arek";
            ka2.Nazwisko = "fjak";
            ka2.Telefon = " 654 443 543";

            KsiazkaAdresowa[] a = new KsiazkaAdresowa[40];
            KsiazkaAdresowa2[] b = new KsiazkaAdresowa2[40];
            a[0].Imie = "arkadiusz";
            a[20].Imie = "arkadiusz";

            for (int i = 0; i < b.Length; i++) // tutaj nie da sie od razu przypisac trzeba rezerowowac miejsce struct dzieki temu dizala szybciej
            {
                b[i] = new KsiazkaAdresowa2();
            }

            b[0].Imie = "arkadiusz";

            Test( ref ka);
            Test(ka2);
            Console.WriteLine(ka.Imie);
            Console.WriteLine(ka2.Imie);
            Console.ReadKey();
        }
        public static void Test(ref KsiazkaAdresowa t) //nowa wersja
        {
            t.Imie = "test";
        }
        public static void Test(KsiazkaAdresowa2 t)
        {
            t.Imie = "gest";
        }
    }
}
struct KsiazkaAdresowa
{
    public String Imie;
    public String Nazwisko;
    public String Telefon;
    public KsiazkaAdresowa(string Imie , string Nazwisko , string Telefon)
    {
        this.Imie = Imie;
        this.Nazwisko = Nazwisko;
        this.Telefon = Telefon;
    }

}
class KsiazkaAdresowa2
{
    public String Imie;
    public String Nazwisko;
    public String Telefon;
}
/* 
 * nie ma Dziedziczenia
 * IStnienje Implementacja Intefejsu
 * Brak F.Wirtualnych
 * Kostruktor bezaprametrowy nie mozna stworzyc
 */
