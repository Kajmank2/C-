using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic works
            //int[] tablica = new int[13] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14, 123 };
            //Console.WriteLine("\nBasic structure of Linq");
            //var nQuery = from VrNum in tablica where (VrNum % 2) == 0 select VrNum;

            //foreach (var VrNum in nQuery)
            //{
            //    Console.WriteLine("{0}", VrNum);
            //}
            //var kQuery = from num in tablica where (num < 3 && num < 7) select num;
            //IEnumerable<int> sieka = tablica.Where(c => c > 15);
            //foreach (var item in sieka)
            //{
            //    Console.WriteLine("{0}", item);
            //}
            //foreach (var item in kQuery)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("{0}", item);
            //}
            #endregion
            //===============================EXAMPLES W3 Resocurces==================\\

            int[] tabliczka = new int[10] { 4, 5, 6, 10, 10, 4, 2, 4, 2, 6 };
            string[] city = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            List<int> lista = new List<int>{ 10, 20, 30, 40, 50 };
            IEnumerable<int> sqrt = from num in tabliczka where num * num > 20 orderby num ascending select num;
            int numCount = tabliczka.Where(n => n < 3 || n > 7).Count();
            var sqNov = from int Numer in tabliczka
                        let SqrNo = Numer * Numer
                        where SqrNo > 29
                        select new { Numer, SqrNo };
            var sqFrq = from x in tabliczka
                        group x by x into y
                        select y;
            //operacja na Sringu
            string str;
            str = Console.ReadLine();
            var sqSTR = from x in str
                        group x by x into y
                        select y;
            //Program wyswietlajacy nam ile jest danych liczb mnozy je i wyswietla ile ich jest
            var sqNumFrq = from x in tabliczka
                           group x by x into y
                           select y;
            //Programik znajdujacy pierwsza i ostatnia litere 
            var sqFEChar = from string x in city
                           let first = x.First()
                           let last = x[x.Length - 1]
                           select new { first, last, x };
            //Zadanie z lista tyle ze ma byc wieksze
            IEnumerable<int> sqList = from x in lista
                                      where x > 20
                                      select x;
            foreach (var item in sqList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in sqFEChar)
            {
                Console.WriteLine(item);
            }

            foreach (var item in sqNumFrq)
            {
                int multiplication = item.Key * item.Count();
                Console.WriteLine("Numer{0} , Count {1}, Frequency{2}" , item.Key ,multiplication , item.Count()); //badz item.Sum();
            }
            

            foreach (var item in sqSTR)
            {
                Console.WriteLine("char {0} ile razy wystapil{1}", item.Key , item.Count());
            }

            foreach (var item in sqFrq)
            {
                Console.WriteLine("Numer {0} Frequency {1}", item.Key , item.Count());
            }

            Console.WriteLine(numCount);
            foreach (var item in sqrt)
            {
                int poteguj = item * item;
                Console.WriteLine("Numer{0} sqrt {1}", item, poteguj);
            }
            Console.ReadKey();
        }
    }
}
