using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyRozszerzajace
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Rra";
            Console.WriteLine(a.IsCapitalized());
            Test b = new Test();
            b.Tester();
            Console.ReadLine();
        }
    }
  static  class StringHelper //Klasa ktora istenie zawsze
    {
        //public static bool IsCapitalized(String value)
        //{
        //    return Char.IsUpper(value[0]);
        //}
        public static bool IsCapitalized( this String value)
        {
            return Char.IsUpper(value[0]);
        }
    }
    class Test
    {

    }
    class Test2 : Test
    {

    }
    static class TestHelper
    {
        public static bool Tester(this Test value)
        {
            return true;
        }
    }

}
