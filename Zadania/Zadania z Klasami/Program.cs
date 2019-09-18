using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania_z_Klasami.Libs;

namespace Zadania_z_Klasami
{
    class Program
    {
        static void Main(string[] args)
        { 

            string s = "Polska Gola";
            Pracownicy prac = new Pracownicy();
            Pracownicy prac2 = new Pracownicy();
            Console.WriteLine(prac.GetName());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(prac.getNationality());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(prac2.GetName());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(prac2.getNationality());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{ prac.firstName}, { prac.secondName}, { prac.city}, { prac.national}");
            Console.WriteLine($"{ prac2.firstName}, { prac2.secondName}, { prac2.city}, { prac2.national}");
            Console.ReadKey();
        }
    }
}
