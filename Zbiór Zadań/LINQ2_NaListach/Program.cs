using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_NaListach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Programik z Lista wypisujący tyle pozycji ile nam trzeba
            int i = 0;
            int memList, n, m;
            List<int> lista = new List<int>();
            Console.WriteLine("Wprowadz ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Member {0}: ", i);
                memList = Convert.ToInt32(Console.ReadLine()); // wprowadzenie czlonka do listy
                lista.Add(memList);
            }
            Console.WriteLine("Input numer which is more than ...");
            m = Convert.ToInt32(Console.ReadLine());
            List<int> filterList = lista.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nThe numbers grater than {0} are ", m);
            foreach (var item in filterList)
            {
                Console.WriteLine(item);
            }
            #endregion Lista
            //int i = 0;
            //int n, tempNum , m;
            //List<int> tempList = new List<int>();
            //Console.WriteLine("Wpisz przedział liczb");
            //n = Convert.ToInt32(Console.ReadLine());

            //for ( i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Number nr  {0} ", i);
            //    tempNum = Convert.ToInt32(Console.ReadLine());
            //    tempList.Add(tempNum);
            //}
            //Console.WriteLine("number to display : ");
            //m= Convert.ToInt32(Console.ReadLine());
            //List<int> MainList = tempList.FindAll(x=>x >m ? true : false);
            //foreach (var item in tempList)
            //{
            //    Console.WriteLine(item);
            //}
            #region lista wyswietlajaca ilosc wierszy
            //List<int> templist = new List<int>();
            //templist.Add(5);
            //templist.Add(7);
            //templist.Add(13);
            //templist.Add(24);
            //templist.Add(6);
            //templist.Add(9);
            //templist.Add(8);
            //templist.Add(7);

            //Console.Write("\nLINQ : Display top nth  records from the list : ");
            //Console.Write("\n----------------------------------------------\n");

            //Console.WriteLine("\nThe members of the list are : ");
            //foreach (var lstnum in templist)
            //{
            //    Console.WriteLine(lstnum + " ");
            //}

            //Console.Write("How many records you want to display ? : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //templist.Sort();
            //templist.Reverse();

            //Console.Write("The top {0} records from the list are : \n", n);
            //foreach (int topn in templist.Take(n))
            //{
            //    Console.WriteLine(topn);
            //}
            #endregion

            string strNew;
            Console.WriteLine("Wprowadz Stringa");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            foreach (var item in ucWord)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(),
                StringComparison.Ordinal));
            return upWord;
        }
        }
    }

