using System;
using System.Text.RegularExpressions;

namespace Solo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.Replace("1A3","[^A-Z]","2"));
            Console.ReadKey();
        }
        static int Sum(int x)
        {
            if (x != 0)
            {
                return x + Sum(x - 1);
            }
            else
                return x;
        }
        public static int hundred(int value)
        {
            value += (100 - value);
            return value;
        }
        class P
        {
            public string N1
            {
                get { return "Jen"; }
                set { }
            }

        }
        class Car
        {
            public void Model()
            {
                Console.WriteLine("n");
            }
        }
        class SpeedCar : Car
        {
            new public void Model()
            {
                Console.WriteLine("s");
            }
        }
        static int Fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            {
                return n * Fact(n - 1); //24-6
            }
        }
        //2,6,18
    }
}
#region Regex 2a2
        //{
        //    Console.WriteLine(Regex.Replace("1A3","[^A-Z]","2"));
        //    Console.ReadKey();
        //}
#endregion
#region ForeachMnznik
//double d = 1.0;
//double[] darr = { 3.0, 0.5, 2.5, 1.5 }; //mnozenie kazdego licznika po kolei
//            for (int i = 0; i<darr.Length; i++)
//            {
//                d *= darr[i];
//            }
//            Console.WriteLine(d);
#endregion
#region FOreachNa-
//int x = 0;
//int[] arr = { 5, 2 };
//foreach (var n in arr)
//{
//    if (n % 2 == 0)
//    {
//        x += n;
//    }
//    else
//        x -= n;
//}
//Console.WriteLine(x);
#endregion
#region Instruckja While
//int x = 0;
//int y = 9;
//            while (x<=5 && y >0) // 1,8 - 2,7 - 3,6 - 4,5 - 5,5 
//            {
//                x++;
//                y--;
//            };
//            Console.WriteLine(x);
#endregion
#region WHILE = dodaje mocy
//int x = 0;
//int y = 9;
//            while (x<=5 && y >0) // 1,8 - 2,7 - 3,6 - 4,5 - 5,5 
//            {
//                x++;
//                y--;
//            };
//            Console.WriteLine(x);
#endregion
#region OdwracanieTablcy

//int x = 1;
//int[] arr = { 5, 7, 4, 2 };
//Array.Reverse(arr);
//            x += arr[1];
//            x *= arr[3];
//            Console.WriteLine(x);
#endregion
#region Rekurencja
//Console.WriteLine(Fact(3) - Fact(2));
#endregion
#region porgram size
//int v = sizeof(int); //float and int = 4 size
//v += sizeof(bool); //bool size = 1
//            Console.WriteLine(v);
#endregion
#region 100
//Console.WriteLine("Hello World!");
//int a = 17;
//if(hundred(a) != hundred(71))
//    Console.WriteLine("tr");
//else
//    Console.WriteLine("fa");
//int b = 31;
//if(hundred(13) == hundred(b))
//    Console.WriteLine("lse");
//else
//    Console.WriteLine("ue");
//Console.WriteLine(hundred(20));
//Console.ReadKey();
#endregion
#region ciekawa tablica gdzie x do przdu  y do tylu
//int[] values = { 1, 2, 3 };
//            for (int x = 0, y=values.Length -2;((x<values.Length)&&(y>=0)); x++, y--)
//            {
//                Console.WriteLine(values[x]); // tablica jesli osiagnie maxa cofa sie do tylu 
//                Console.WriteLine(values[y]); 
//            }
#endregion
#region fajna tablica 
//int y = 0;
//            for (int x = 0; x< 9; x++)
//            {
//                x++;
//                y++;
//                Console.WriteLine(x);
//            }
#endregion
#region tablica ze stopem
//int j = 0;
//            for (int i = 1; i< 10 && i!= 7; i++) // jesli jest rozne tablica sie stopuje
//            {
//                Console.WriteLine(i);
//                j++;
//            }
//            Console.WriteLine(j);
#endregion
#region ciekawy regionek z suma 6,5,4,3,2,1
//int x = 6;
//x = Sum(x);
//Console.WriteLine(x);
#endregion