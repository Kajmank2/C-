using System;

namespace Zabawa_z_metodami
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // tak nie daje rady
            Math.IncreseBy5(ref a);
            Console.WriteLine(a); // tak nie daje rady , potrzebna jest referncja


            int b; // Zerowanie
            Math.Zeruj(out b);
            Console.WriteLine(b);
            //parametry
            Console.WriteLine(Math.Dodaj(1, 1, 1, 1, 1, 1, 1, 1, 1));
            //Potegi
            Console.WriteLine(Math.Poteguj(4, 3));
            Console.WriteLine(Math.Abs(-4)); // wartosc bezwzgledna jesli jest if musza byc postawione 2 warunki
            Console.WriteLine("Hello World!");
            // Obywatel get set 
            Console.WriteLine("Obywatel Welcome");

            Obywatel obywatel = new Obywatel("arkadiusz", "flecik");
            //obywatel.Imie = "lala"; nie mozna zmienic dzieki private Set
            Console.WriteLine(obywatel.Imie + obywatel.Nazwisko);
        }

        class Math
        {
            public static int Abs(int x)
            {
                if (x < 0)
                    return x * (-1);
                return x;
            }
            public static int IncreseBy5(ref int nr) // aby to ładnie dizala trzeba dało referencje
            {
                nr += 5;
                return nr;
            }
            public static int IncreseBy5(int nr) // Zrobiony jest overloading czyli mozna zrobic to wypisanie na 2 sposoby
            {
                nr += 5;
                return nr;
            }

            public static void Zeruj(out int b)
            {
                b = 0;
            }

            public static int Dodaj(params int[] args) // parametry nieograniczona ilosc 

            {
                int suma = 0;
                for (int i = 0; i < args.Length; i++)
                {
                    suma = suma + args[i];
                }
                return suma;
            }

            public static int Poteguj(int podstawa_potegi, int wykladnik)
            {
                int tmp = 1;
                for (int i = 0; i < wykladnik; i++)
                {
                    tmp *= podstawa_potegi;
                }
                return tmp;
            }
        }
        class Obywatel
        {
            public string Imie { get; private set; } // uniemozliwiamy zmiane
            public string Nazwisko { get; set; }

            public Obywatel(string imie, string nazwisko)
            {
                this.Imie = imie;
                this.Nazwisko = nazwisko;
            }
        }
    }

}
