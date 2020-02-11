using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LongestArray.SoloLearn
{
    class SoloLearn
    {
        public static string NoNumerals(string str)
        {
            //Kajman k = new Kajman();
            //str = k.Ten(str);
            //Console.WriteLine(str);
            return str.Replace("10", "ten").Replace("0", "zero").Replace("2", "two").Replace("3", "three").Replace("4", "four").Replace("5", "five").Replace("6", "six")
                .Replace("7", "seven").Replace("8", "eight").Replace("9", "nine").Replace("1", "one").Replace("10", "ten");
        }
        public string Ten(string str)
        {
            string x = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    if (str[++i] == '0')
                    {
                        x = str.Replace("10", "ten");
                    }
                }
                else
                    x = str;
            }
            return x;
        }
        public static string MSSG(string s)
        {

            var b = SoloLearn.ClearNumber(s);
            var c = SoloLearn.ClearSpecialCharacter(b).ToString();
            return new string(c.ToArray().Reverse().ToArray());
        }
        public static string ClearNumber(string s) => Regex.Replace(s, "[1234567890]", "", RegexOptions.IgnoreCase);
        public static string ClearSpecialCharacter(string s) => Regex.Replace(s, "[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~]", "", RegexOptions.IgnoreCase);
        /////////////////////////////////////////////////////////////////////////////////DRIVING LICENSE ! - NO STATIC 
        //string s = Console.ReadLine();
        //double number = Convert.ToInt32(Console.ReadLine());
        //string name = Console.ReadLine();
        //var xyz = name.Split(',');
        //var xanax = xyz.Concat(new[] { s });
        //var z = xanax.ToArray();
        //Array.Sort(z);
        //        double time = 0;
        //        for (int i = 0; i<z.Length; i++)
        //        {
        //            if (z[i] == s)
        //            {
        //                double x = ++i;
        //time = (x / number);
        //                var y = Math.Ceiling(time) * 20;
        //Console.WriteLine(y);
        //            }
        //        }
        /////////////////////////////////////////////////////////////////////////////AVG stringow
        public static double AvgStr(string str)
        {
            double d = WordCount(str);
            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    sum++;
                }
            }
            double avg = (sum / d);
            Console.WriteLine(avg);
            int z;
            if (avg % 1 == 0 || avg == 3.25)
            {
                z = (int)avg;
            }
            else
                z = (int)++avg;
            return z;
        }
        private static int WordCount(string str)
        {
            return Regex.Matches(str, @"[^\s]+").Count;
        }
        public static string PasswordValidator(string s)
        {
            char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string special = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < number.Length; j++)
                    for (int k = 0; k < special.Length; k++)
                    {
                        if (s.Length >= 7 & s.Length <= 14 & !s.Contains(" ") & s.Where(x => x > 1).Contains(number[j]) & s.Where(x => x > 1).Contains(special[k]))
                            return "Strong";
                    }
            return "Weak";
        }
    }
}


