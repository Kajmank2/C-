using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WartoscinullDlaTypowWartosciowych
{
    class Program
    {
        public static int? getSomethingFromDataBase()
        {
            return null;
        }
        static void Main(string[] args)
        {
            int? a = getSomethingFromDataBase();
            //Nullable<int> a = getsomethingfromdatabase

            if(a == null)
                Console.WriteLine("Nie podales a");
            else
                Console.WriteLine(a);
            int b = a ?? 0; // a ?? 0 ; oznacze ze przypisz wartosc a JEzeli nie istnieje to przypisz to co jest po pytajniku
            Console.ReadKey();
        }
    }
}
