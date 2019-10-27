using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int twojwynik = 0;
            int wynikKomputera = 0;
            int losKomputera;

            while (true)
            {
                string los;
                Console.WriteLine("co losujesz (k - kamien,p - papier , n nozyce)?");
                los = Console.ReadLine();
                losKomputera = rand.Next(0,3);
                Console.WriteLine("komputer dal {0} ", (Reka)losKomputera);

                switch (los)
                {
                    case "k":
                        switch(losKomputera)
                     {
                     case 0:
                        Console.WriteLine("remis");
                        break;
                    case 1:
                        Console.WriteLine("wygrales");
                        break;
                    case 2:
                        Console.WriteLine("przegrales");
                        break;
                }
                        break;

                    case "p":
                        switch (losKomputera)
                        {
                        case 0:
                            Console.WriteLine("wygrales");
                            break;
                        case 1:
                            Console.WriteLine("remis");
                            break;
                        case 2:
                            Console.WriteLine("przegrales");
                            break;
                        }
                        break;
                    case "n":
                        switch (losKomputera)
                        {
                        case 0:
                            Console.WriteLine("przegrales");
                            break;
                        case 1:
                            Console.WriteLine("wygrales");
                            break;
                        case 2:
                            Console.WriteLine("remis");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("jestes Kaszname wprowadz p , k ,n");
                        break;
                }
            }
        }
    }
}
