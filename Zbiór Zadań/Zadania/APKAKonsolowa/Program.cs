using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APKAKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            Mob mob = new Mob();
            Console.WriteLine("zaczynamy walke");

            while(czlowiek.Health > 0 && mob.Health > 0)
            {
                Console.WriteLine("Moje hp {0},Moba HP :{1}", czlowiek.Health, mob.Health);
                czlowiek.PrzyjmijObrazaenia(mob.GenrateSlash());
                mob.PrzyjmijObrazenia(czlowiek.GenerateSlash());
            }
            if (czlowiek.Health > 0)

                Console.WriteLine("pozdrowionka wygrales");
            else if (mob.Health > 0)
                Console.WriteLine("przegrales");
            else
                Console.WriteLine("mamy remisik");
            Console.ReadKey();

        }
    }
}
