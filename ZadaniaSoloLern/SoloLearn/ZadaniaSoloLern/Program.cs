using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaSoloLern
{
    class Program
    {
        #region Kolejka
        //    static void Main(string[] args)
        //    {
        //        #region Kolejka
        //        //Queue<int> quen = new Queue<int>();
        //        //quen.Enqueue(1);
        //        //quen.Enqueue(29);
        //        //quen.Enqueue(26);
        //        //Console.WriteLine(quen.Dequeue());
        //        //Console.WriteLine(quen.Count);
        //        //Console.ReadKey();
        //    }
        #endregion
        #region Funkcja float
        //    static float Func(float a , float b)
        //        {
        //            return a % b;
        //        }
        //        static float Func(int a , int b)
        //    {
        //        return a * b;
        //    }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Func(Func(2, 3), 4));
        //        Console.ReadKey();
        //}
        #endregion
        #region iNT 32 NA DOUBLE
        //public static void Main()
        //{
        //    double d = 3.5;
        //    int i = Convert.ToInt32(d); //4
        //    Console.WriteLine(i + d);
        //    Console.ReadKey();
        //}
        #endregion
        #region program w sumie latwy
        //static void Main()
        //{ 
        //    int x = 6;
        //    int y = 4;
        //    if (x * x + y * y > 50)
        //        x %= y; //2
        //    else
        //        x *= y ; 
        //    Console.WriteLine(x);
        //    Console.ReadKey();
        //}
        #endregion
        #region podwojna petla
        //public static void Main()
        //{
        //    int x = 4;
        //    int y = 9;
        //    while(x<=5 && y > 0)
        //    {
        //        x++;
        //        y--;
        //    };
        //    Console.WriteLine(x);
        //    Console.ReadKey();
        //}
        #endregion
        #region Dziwne Klasy dające sobie wartośc b = a jest przypisanie dlatego oba odnosza sie do sb
        //class SomeClass
        //{
        //    public int someField;
        //    static void Main()
        //    {
        //        SomeClass a = new SomeClass();
        //        SomeClass b = new SomeClass();
        //        a.someField = 3;
        //        b = a;
        //        b.someField = 4;
        //        a.someField++;
        //        b.someField++;
        //        Console.WriteLine(b.someField);
        //        Console.ReadLine();
        //  }
        //}
        #endregion
        #region Tablica
        //public static void Main()
        //{
        //    int[] a = new int[5];
        //    for (int i = 0; i < 5; i += 2)
        //    {
        //        a[i] = i * 2;
        //        Console.WriteLine(a[i]);
        //    }
        //    for (int i = 0; i < 5; i++)
        //        Console.WriteLine(a[i]);
        //    Console.ReadKey();
        #endregion
        #region Randomik
        //public static void Main()
        //{
        //    Random rand = new Random();
        //    int r;
        //    for (int i = 0; i < 5; i++) //losowanie 5 liczb od 0 do 1
        //    {
        //        r = rand.Next(1, 2);
        //        Console.WriteLine(r);

        //    }

        //    int x = rand.Next(1, 3);
        //    Console.WriteLine(x);
        //   Console.ReadKey();
        //}
        #endregion
        #region Fajna Tablica podwójna
        //public static void Main()
        //{
        //    int x = 0;
        //    int[,] m = new int[,]
        //    {
        //        { 42, 21, 32 }, { 73, 65, 58 }, { 25, 53, 17 }
        //    };
        //    for (int i = 0; i < 2; i++)

        //        x += m[2 - i, i];
        //    Console.WriteLine(x);
        //    Console.ReadKey();
        //}
        #endregion
        #region Petelka
        //public static void Main() {
        //    int x = 3, y = 1;
        //    do
        //    {
        //        y++;
        //    } while (x-- >= 0);
        //    Console.WriteLine(y);
        //    Console.Read();
        //}
        //static void Main()
        //{
        //    int x = 1;
        //    int y = 0;
        //    try
        //    {
        //        x = x / y;
        //    }
        //    catch (ArithmeticException)
        //    {
        //        x = 2; //wylapal 2 jako prawidlowe
        //    }
        //    catch (Exception)
        //    {

        //        x = 3;
        //    }
        //    finally
        //    {
        //        x += 5;
        //    }
        //    Console.WriteLine(x);
        //    Console.ReadKey();
        //}
        #endregion
        #region Funkcja z szybka SIlnia
        //static int Fact(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }else
        //    return n * Fact(n - 1); //SIlnia
        //}
        //static void Main()
        //{
        //    Console.WriteLine(Fact(4)-Fact(3));
        //    Console.ReadKey();

        //}
        #endregion
        #region Ciekawy switch
        enum Lngs
        {
            java=2,
            cpp = 4, 
            c=7,
            cs
        }
        static void Main()
        {
            Lngs x = Lngs.cs; // to jest nastepna liczba po c
            switch (x)
            {
                case Lngs.cs:
                    Console.Write((int)Lngs.cs);
                    break;
            }
            Console.ReadKey();
        }
        #endregion
    }
}


