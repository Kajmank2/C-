using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag bohater1 = new Mag();
            Mag bohater2 = new Mag("Gargamel", 10, 5);

            Console.WriteLine(bohater1);
            Console.WriteLine(bohater2);

            Wojownik bohater3 = new Wojownik();
            Wojownik bohater4 = new Wojownik("Rumcajs", 10);
            bohater3.ZmienZywotnosc(-90);

            Console.WriteLine(bohater3.ToString());
            Console.WriteLine(bohater4);
            

            Console.WriteLine("\nTworze druzyne\n");

            Druzyna druzyna = new Druzyna("Druzyna pierscienia");
            druzyna.Dodaj(bohater1);
            druzyna.Dodaj(bohater2);
            druzyna.Dodaj(bohater3);
            druzyna.Dodaj(bohater4);

            Console.WriteLine(druzyna);
            Console.ReadLine();
        }
    }
}
