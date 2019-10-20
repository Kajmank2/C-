using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            string c;

            c = Console.ReadLine();
            try
            {
                if (a == 10)
                    throw new OurNameException("a bylo rowne 10 a nie moze byc");
                int tmp = Convert.ToInt32(c);
                Console.WriteLine(a/tmp);
                Console.WriteLine("lala");
            }
            catch (DivideByZeroException e) // zapisujemy wyjatek najpierw te wyspecjalizowane podajemy na koncu ogolny
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // zapisujemy wyjatek
            {
                Console.WriteLine(e.Message);
            }
            finally //wykona sie zawsze
            {
                Console.WriteLine("JA pokaze sie zawsze , sluze do czyszczenia , zamykania plikow,polaczen");
            }
            Console.WriteLine(a/b);
            Console.ReadKey();
        }
    }
    class OurNameException : Exception //wszystkie wyjatki dziecizymy
    {
        public OurNameException(string msg) : base(msg)
        {

        }
    }
}
