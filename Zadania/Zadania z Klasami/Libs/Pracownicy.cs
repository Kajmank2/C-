using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_z_Klasami.Libs
{
    class Pracownicy
    {
        public string firstName;
        public string secondName;
        public string city;
        public string national;

        public string GetName()
        {
            Console.WriteLine("Podaj Imie");
            firstName = Console.ReadLine();
            Console.WriteLine("Podaj znazwisko");
            secondName = Console.ReadLine();
            return $"Witaj  {firstName} {secondName} ";   
        }



        public string GetPlace()
        {
            Console.WriteLine("wprowadz swoją Narodowość");
            national = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("wprowadz swoje miasto");
            city = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            return national;
        }
        public string getNationality()
        {
            if (GetPlace() == "Polska")
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"twoj piekny kraj i miasto to {national}{city}");
                }
            }
            else
            {
                Console.WriteLine("Nie pojemaju pa ruski");
               
            }
            return $"dziekujemy";
           


        }
       
    }
}
