using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_Uogolnione___statyczne_i_domyslne_wartosci
{
    class Program
    {
        static void Main(string[] args)
        {
            new Test<A>();
            StaticTest<int>.x++;
            StaticTest<double>.x++;
            StaticTest<Test<A>>.x++;
            Console.WriteLine(StaticTest<int>.x);
            Console.ReadKey();
        }
    }
    //COnstraint ograniczenia
    /*
     * where T : class - T musi byc typu klaowego
     * where T : struct - t musi byc typu strukturalnego
     * where t : INazwaInterfejsu - typ T musi implementowac INazwaIntefejsu , lub tez jest tym interfejsem
     * where T : NazwaKlasy - Typ T musi byc typem NazwaKlasy lub tez typem dziedziczącym po NazwaKlasy
     * where T : new() = typ T mial bezparametrowy konstruktor
     * */
    class Test<T> where T : Ilala, new() // nie trzea pisac slowka inteface mozna to polaczyc 
    {
        public T zm { get; private set; }
        public Test()
        {
            this.zm = default(T);
        }
    }
    interface Ilala
    {

    }
    class A : Ilala // a tez dziala pomimo ze mu implementowac interfejs
    {

    }
    class B
    {

    }
    class C : B {
    }
    abstract class Kalkulator<T> where T  : struct
    {
        public abstract T Dodaj(T x, T y);
        public abstract T Odejmij(T x, T y);
    }
    class IntKalkulator : Kalkulator<int>
    {
        public override int Dodaj(int x, int y)
        {
            return x + y;
        }
        public override int Odejmij(int x, int y)
        {
            return x - y;
        }
    }

    class DoubleKalkulator<U> : Kalkulator<double>
    {
        U zmTypuU;
        public override double Dodaj(double x, double y)
        {
            return x + y;
        }
        public override double Odejmij(double x, double y)
        {
            return x - y;
        }
    }
    class StaticTest<T>
    {
        public static int x;
    }
}
