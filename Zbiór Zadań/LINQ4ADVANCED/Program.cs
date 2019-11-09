using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ4ADVANCED
{
    class Program // Usuwanie znakow z listy razem z RemoveRange() - usuwa dane pozycje
    {
        static void Main(string[] args)
        {
            #region Zadnako z usuwaniami Charów i Range 
            //int i, n;
            //var list = new List<char>();
            //Console.WriteLine("Input the number of Char");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Char 1 [{0}] :", i);
            //    char tempList = Convert.ToChar(Console.ReadLine());
            //    list.Add(tempList);
            //}
            //var _result1 = from y in list select y;
            //Console.WriteLine(" Podaj Char do usuniecia");
            //char dChar = Convert.ToChar(Console.ReadLine());
            //char newstr = list.FirstOrDefault(x => x == dChar);
            //list.Remove(newstr);
            //Console.WriteLine("Input range to delete !  nr = ");
            //int rn1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input range to delete !  nr = ");
            //int rn2 = Convert.ToInt32(Console.ReadLine());
            //list.RemoveRange(rn1,rn2);
            //Console.WriteLine("Podaj przedział liczb do usuniecia");


            //var _result = from z in list select z;
            //foreach (var item in _result)
            //{
            //    Console.WriteLine("Char  : {0}" , item);
            //}
            #endregion
            int n, m;
            string[] arr;
            Console.WriteLine("Wprowadz rozmiar tablicy");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new string[n];
            Console.WriteLine("Wprowadz rozmiar tablicy");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Wprowadz członków do tabliczki {0}",i);
                arr[i] = Console.ReadLine();
            }
            var DisplaySTR = from x in arr select x;
            foreach (var item in DisplaySTR)
            {
                Console.WriteLine(item);
            }
            var ns = from z in arr where z.Length >= 5 // tą piątke dodatkowo można sobie zmienna zastąpic aby wybrana była mozliwosc wpisywania
                     orderby z descending
                     select z;
            IEnumerable<string> zizu = arr.Where(x => x.Length >= 5); // 2 sposob
            foreach (var item in zizu)
            {
                Console.WriteLine(" Pierwsza liczba powyzej 5 znaków");
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
