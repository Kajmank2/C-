using System;
using System.Linq;
using System.Text;

namespace LINQ3ADVANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[3] { "Jacek", "Grzesiek", "Łukasz" };
            for (int f = 0; f < tablica.Length; f++)
            {
                Console.WriteLine(tablica[f]);
            }
            string[] arr1;
            int n, i;
            Console.WriteLine("Wprowadz wielkosc stringowej tablicy");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings for the array  :\n", n);
            string newstring = String.Join(", ", arr1
                          .Select(s => s.ToString())
                          .ToArray());
            Console.Write("\nHere is the string below created with elements of the above array  :\n\n");
            Console.WriteLine(newstring);
            Console.Write("\n");

            Console.WriteLine(ConvertArrayToString(tablica));
            Console.WriteLine(ConvertArrayToString(arr1));
            Console.ReadKey();
        }
        public static String ConvertArrayToString(String[] strArray)
        {
            StringBuilder myb = new StringBuilder();
            for (int i = 0; i < strArray.Length; i++)
            {
                myb.AppendJoin(' ', strArray[i], " ");
            }
            return myb.ToString();
        }
    }
}
