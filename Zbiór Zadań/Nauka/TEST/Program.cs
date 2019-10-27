using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string allWords = "PHP TUTORIAL";
            //string s=String.Format(allWords.Replace("PH", ""));
            string str = "PHP Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
            //  Console.WriteLine(s);
              Console.ReadKey();
        }
    }
}