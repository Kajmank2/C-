using System;
using System.Collections;
using System.Collections.Generic;

namespace KlasyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(5);
            lista.Add(52);
            lista.Add(51);
            lista.Add("Karol Kar");
            lista.Add(new Test("Hejka"));
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString()); //rzutowanie nie pomaga aby wylowac klase test
            }

            List<int> listaInt = new List<int>();
            {
                listaInt.Add(3);
                lista.Add(12);
            }
            List<Test> tests = new List<Test>();
            {
                tests.Add(new Test("Halko"));
                tests.Add(new Test("Siemanko koleego"));
            }
            for (int i = 0; i < tests.Count; i++)
            {
                Console.WriteLine(tests[i].TestowyString);
            }
            var zm = new Zwykla<String>();
            var xm = new Zwykla<int>();
            xm.nadajWartosc(1);
            zm.nadajWartosc("hejka jestem ze zwyklej");
            Console.WriteLine(zm.zwrocWArtosc());
            Console.ReadKey(); 
        }
    }
    class Test
    {
        public string TestowyString
        {
            get;
            private set;
        }
        public Test(string TestowyString)
        {
            this.TestowyString = TestowyString;
        }
        public override string ToString()
        {
            return this.TestowyString;
        }
    }
    class Zwykla<Cokolwiek>
    {
        Cokolwiek nazwacokolwiek;

        public Cokolwiek zwrocWArtosc()
        {
            return this.nazwacokolwiek;
        }
        public void nadajWartosc(Cokolwiek cokolwiek)
        {
            this.nazwacokolwiek = cokolwiek;
        }
    }
}

