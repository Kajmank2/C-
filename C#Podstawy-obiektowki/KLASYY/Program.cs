using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASYY
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Pracownicy prac1 = new Pracownicy();
            prac1.Imie = "karol";
            prac1.Nazwisko = "Kaim";
            prac1.salary = "za niskie";
            
            IncresaseSalary(prac1);
         Console.WriteLine($"pracowni numer 1 to {prac1.GetName()} {prac1.salary}");
            Console.ReadKey();
        }

        static void IncresaseSalary(Pracownicy pracownicy)
        {
            pracownicy.salary = "wystarczajace by przezyc";
        }
    }
}
