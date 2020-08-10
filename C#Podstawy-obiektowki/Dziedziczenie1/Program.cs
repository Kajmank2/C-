using Dziedziczenie.Libs;
using System;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dziedziczenie -Paradygmat programowania - atomowsc
            // 1Cecha ojec (przechodza na jego potomka) 
            //2interfejs - kontrakt z klasa dziedziczącą
            //3klasa abstrakcyjna
            var p1 = new KarolPendrive("siemanko widzieliscie gdzies zbyszka");
            p1.SetColor("czarny");
            var p2 = new KingstonPendrive("seat toledo czarna strzala");
            p2.SetColor("rózowy");
            Console.WriteLine(p1 is IMemorable);
            Console.WriteLine(p1.GetColor());
            Console.WriteLine(p2.GetColor());


            Console.ReadLine();
        }
    }
}
