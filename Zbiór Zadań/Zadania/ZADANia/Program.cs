using System;
using System.Collections.Generic;

namespace ZADANia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zad 1 
            //int a, b,suma;
            //Console.WriteLine("podaj a");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("podaj b");
            //b = int.Parse(Console.ReadLine());
            //suma = a + b;
            //if((a == 20) || (suma ==20))
            //{
            //    Console.WriteLine(true);
            //} else
            //{
            //   Console.WriteLine(false);
            //}
            #endregion
            #region zadnaia z upper stringi elko szukanie najdluzszego znaku
            string lancuch = " Elko elko hejasddsako hejko ";
            string[] words = lancuch.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (var s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
            #endregion
            #region while wyswietlajacy sume 500 liczb
            //int i = 0;
            //int sum = 0;
            //while ( i < 500)
            //{
            //    i++;
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            #endregion
            #region Porgram 12 = 3


            //Console.WriteLine("podaj liczbe");
            //int liczba = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while(liczba != 0)
            //{
            //    sum += liczba % 10;
            //    liczba /= 10;
            //}
            //Console.WriteLine("liczba to " +sum);
            //Console.ReadLine();
            #endregion
            #region stringi zamiana znaków
            //          string line = "Display the pattern like pyramid using the alphabet.";
            //          Console.WriteLine("\nOriginal String: " + line);
            //          string result = "";
            //          List<string> wordsList = new List<string>();
            //          string[] words = line.Split(new[] {
            // " "
            //}, StringSplitOptions.None);
            //          for (int i = words.Length - 1; i >= 0; i--)
            //          {
            //              result += words[i] + " ";
            //          }
            //          wordsList.Add(result);
            //          foreach (String s in wordsList)
            //          {

            //              Console.WriteLine("\nReverse String: " + s);

            #endregion
            #region usuwanie znakow
            string allWords = "PHP TUTORIAL";
           // string s = String.Format(allWords.Replace("PH", ""));
            string str = "PHP Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
            #endregion
            Console.ReadLine();

            #region Zamina znakow
            //string str = "CHuj CIpka";
            //string result = "";
            //if (str.Length >= 1 && str[0] == 'C')
            //    result += str[2];
            //Console.WriteLine(result);
            #endregion
            #region
            var a = 15;
            var b = 12;
            if (a>b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
            #endregion
        }
    }
    }

