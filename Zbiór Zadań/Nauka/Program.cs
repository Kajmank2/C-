using System;
using System.Text;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program1
            //Console.WriteLine("podaj temperature ");
            //string str = Console.ReadLine();
            //Console.WriteLine("aktualna temperatura" + str);
            //int temp = int.Parse(str);
            //if(temp > 32)
            //{
            //    Console.WriteLine("elo elo");
            //}else
            //{
            //    Console.WriteLine("ELO 420");
            //}

            //Program 2 ze switchem
            // Console.WriteLine("Podaj temperature");
            // var str = Console.ReadLine();
            // Console.WriteLine(" aktualna temperatura, {0}" + str);
            // int temp;
            // int.TryParse(str, out temp);
            // switch (temp)
            // {
            //  case 32:
            // Console.WriteLine("temperatura jest rowna 32");
            // break;
            //     case 43:
            //         Console.WriteLine("temperatura jest rowna 43");
            //         break;

            //     default:
            //        Console.WriteLine ("wyjebalo temperature" + temp);
            //         break;
            //}
            //            porgram 3
            //            int temp = 26;
            //            const int FREEZING = 0;
            //            const int BOILING = 100;
            //            const int ROOMTEMP = 24;

            //            if( temp > FREEZING && temp< BOILING)
            //            {
            //                Console.WriteLine("Woda jest w stanie cieklym w temp. {0}",temp);
            //            }else if (temp <=FREEZING)
            //            {
            //                Console.WriteLine("Woda jestw stanie stalym ", temp);
            //            }
            //Program 4 petle
            int val = 15;
            while (val < 20)
            {
                Console.WriteLine(string.Format("wartosc zmiennej val = {0}", val));
                val += 1;
            }
            do
            {
                Console.WriteLine(string.Format("wartosc zmiennej val = {0}", val));
                val += 1;
            } while (val < 20);
            for (val = 15; val < 20; val++)
            {
                Console.WriteLine(string.Format("wartosc zmiennej val = {0}", val));
            }
            Console.ReadKey();
            //Program 5
            //    int a = 3;
            //    int res = polekw(a);
            //    Console.WriteLine("Pole kwadratu o boku u {0} wynsio{1},",a,res);

            //    Console.ReadLine();

            //}
            //static int polekw(int a)
            //{
            //    return a * a;
            //}
            //Program 6
            //int  temp = 3;
            //  bool? res = null;
            //  if (temp == 3)
            //  {
            //      res = true;
            //  }else if (temp > 3)
            //  {
            //      res = false;
            //  }
            //  else
            //  {
            //      res = null;
            //  }
            //  Console.WriteLine(res);
            //      Console.ReadLine();
            //Program 7 szybsze wyswietlanie stringow
            //char t = 'S';

            //StringBuilder result = new StringBuilder();

            //for(int c = 0; c < 1000; c++)
            //{
            //    result.Append("Lorem lipsum nth time");
            //}
            //Console.WriteLine(result);
            // KlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasyKlasy

        }
    }
}
