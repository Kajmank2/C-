using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn2
{
    struct Struct
    {
        public int x { get; set; }
    }
    struct F
    {
        public int i;
    }

    class Program
    {
        public static string GetOne(string s, int i)
        {
            string[] split = s.Split(':');
            return split[i--];
        }
        static int func1(int x)
        {
            return 1;
        }
        static char func1(ref int x)
        {
            return 'c';
        }
        static float func1<T>(T x) where T : class
        {
            return 1.2f;
        }




        static void Main(string[] args)
        {
            double d = 1.0;
            double[] darr = { 3.0, 0.5, 2.0, 1.5 };
            for (int i = 0; i < darr.Length; i++)
            {
                d *= darr[i];
                Console.WriteLine(darr[i]);
            }
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
#region banalne zadanie na klasy
//class Bar
//{
//    Bar bar = new Bar(8);
//    Test test = new Test();
//    Console.WriteLine(test.Add(7,bar));
//    public int foo;
//    public Bar(int foo)
//    {
//        this.foo = foo;
//    }
//}
//class Test
//{
//    public int Add(int foo , Bar bar)
//    {
//        return foo + bar.foo;
//    }
//}
#endregion
#region clasa person statyczna 
//class Person
//{
//    private static int a = b++; //0:1:3
//    private static int b = ++c;
//    private static int c = 3;
//    public Person()
//    {
//        Console.WriteLine(a + ":" + b + ":" + c);
//    }
//    Person p = new Person();
//}
#endregion
#region tablica z porownaniem z 2 zmiennymi
//int[] arr = { 10, 15, 16 };
//var x = arr.FirstOrDefault(z => z.Equals(14));
//Console.WriteLine(x);
//            Console.ReadLine();
#endregion
#region zadanako z tablia double mnozaca ostatni wers  * 1,5
//double d = 1.0;
//double[] dar = { 3.0, 0.5, 2.0, 1.5 };
//for (int i = 0; i < dar.Length; i++)
//{
//    d *= dar[i]; // FInalnie 1.5*3
//}
//Console.WriteLine(d);
#endregion
#region tablica jedno + drugie minus + liczenie usmy
//int sum = 0;
//            for (int i = 5;  i>0; i--)
//                for (int j = 1; j<i; j++) // zapisuje sumy 1 iteracja 5,1 druga 4,2 trzecia 3,3 suma daje nam 20
//                    sum += j;
//            Console.WriteLine(sum);
#endregion
#region tablica 2 wymiarowa liczace suma
//int[,] array = new int[2, 2] { { 1, 1 }, { 2, 1 } };
//int mult = 1;
//            for (int i = 0; i< 2; i++)
//            {
//                int sum = 0;
//                for (int j = 0; j< 2; j++)
//                {
//                    sum += array[i, j];
//                }
//                mult *= sum;
//            }
#endregion
#region Fibonnaci sumla
//int[] fibs = { 0, 1, 1, 2, 3, 5, 8, 9 }; // liczby fibponacziego wykluczajace 5 
//int n = fibs.Count(x => x != 5);
//Console.WriteLine(n*2);
#endregion
#region Strukturka prosta
//Struct s1 = new Struct();
//Struct s2 = s1;
//s2.x = 20;
//            Console.WriteLine(s2.x  );
//            Console.ReadKey();
#endregion
#region Strukturka2
//F x = new F();
//x.i = 10;
//            fun(ref x);
//Console.WriteLine(x.i);
#endregion
#region Dzielenie stringow
//public static string GetOne(string s, int i)
//{
//    string[] split = s.Split(':');
//    return split[i--];
//}

//string s = "cat:dog:try:cry";
//int b = 2;
//Console.WriteLine(GetOne(s, ++b));
#endregion
#region Wybor staticaa
//int num = 770;
//char fiat = 'f';
//var result = func1(fiat);
//Console.WriteLine(result);
//            Console.ReadKey();
#endregion
#region z.equeals
//int[] arr = { 10, 15, 16 };
//var x = arr.FirstOrDefault(z => z.Equals(14));
//Console.WriteLine(x + 15);
//            Console.ReadKey();
#endregion