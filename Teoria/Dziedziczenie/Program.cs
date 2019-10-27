using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Display(Punkt p)
        {
            //if(p is Punkt3d) // IS 
            //    Console.WriteLine(((Punkt3d)p).PobierzWsp());
            //else
            //Console.WriteLine(p.PobierzWsp());

            Punkt3d p3d = p as Punkt3d; 
            if (p3d == null) // kiedy nie jest mozliwe w p3d bedzie null
                Console.WriteLine(p.PobierzWsp());
            else
                Console.WriteLine(p3d.PobierzWsp());
        }
        static string getClassName(Object x)
        {
            return x.ToString();
        }
        static void Main(string[] args)
        {
            Punkt punkt = new Punkt(5, 10);
            Console.WriteLine(punkt.PobierzWsp());
             
            Punkt3d punkt3d = new Punkt3d(1, 2, 3);
            Console.WriteLine(punkt3d.PobierzWsp()); // rzutowanie

            Punkt a;
            Punkt b;
            a = new Punkt(1, 5);
            b  = new Punkt3d(1, 2, 3);
            Display(a);
            Display(b);
            Console.WriteLine(getClassName(b));

         //   Console.WriteLine(a.PobierzWsp());
          //  Console.WriteLine(((Punkt3d)b).PobierzWsp()); //rzutowanie
            Console.ReadKey();
        }
    }
}
