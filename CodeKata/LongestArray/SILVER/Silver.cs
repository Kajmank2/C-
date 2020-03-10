using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestArray.SILVER
{
  public static class Silver
    {
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //return sum;
        }
        public static int StrCount(string str, string letter)
        {
            int count = 0;
            char x = Convert.ToChar(letter);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == x)
                {
                    count++;
                }
            }
            return count;
        }
        //public static string OddOrEven(int[] array)
    //{
    //    return array.Sum() % 2 == 1 || array.Sum() % 2 == -1 ? "odd" : "even";
    //    return array.Sum() % 2 == 0 ? "even" : "odd";
    //}   public static int GetNumber(string str)
        //{
        //    return Enumerable.Range(0, str.Length - 4).Select(i => Convert.ToInt32(str.Substring(i, 5))).ToList().Max();
        //}
        //public static string ToAlternatingCase(this string s)
        //{
        //    var low = s.ToLower().ToCharArray();
        //    var Up = s.ToUpper().ToCharArray();
        //    string str = "";
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int j = 0;
        //        j++;
        //        int k = 0;
        //        k++;
        //        if (s[i] == low[i])
        //        {
        //            str += s[i].ToString().ToUpper();
        //        }
        //        else if (s[i] == Up[i])
        //        {
        //            str += s[i].ToString().ToLower();
        //        }
        //        else
        //            str += s[i];
        //    }
            //  return str;
            // return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
            // return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
        //}
        ///////////////////////////////////////////////////////////Array sum
        public static double SumArray(double[] array)
        {
            var b = array.ToList();
            double sum = 0;
            if (array.Length == 0)
            {
                return 0;
            }
            else
            {
                sum = b.Sum();
            }
            return sum;
         //   return array.Sum();
        }
        /////////////////////////////////////////////////////Change name 
        public static string NameShuffler(string str)
        {
            string s = "";
            var str1 = str.Split(' ');
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                s += str1[i] + " ";
            }
            s = s.TrimEnd(' ');
            return s;
            //  string.Join(" ", str.Split(' ').Reverse());
        }
        //////////////////////////////////////////////////////////////////// IS the string Uppercase ?
        public static bool IsUpperCase(this string text)
        {
            if (text.Length == 0)
            {
                return true;
            }
            var b = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                if (text == b)
                {
                    return true;
                }
            }
            return false;
            //Other Solution
            //return value.ToUpper() == value;
            //return !s.Any(x => Char.IsLower(x));
            //return !str.Any(x => char.IsLower(x));
        }
        ///////////////////////////////////////////////////////////Grasshoper - GRADE Book
        public static char GetGrade(int s1, int s2, int s3)
        {
            double d = (s1 + s2 + s3) / 3;
            if (d >= 0 & d < 60)
            {
                return 'F';
            }
            else if (d >= 60 & d < 70)
            {
                return 'D';
            }
            else if (d >= 70 & d < 80)
            {
                return 'C';
            }
            else if (d >= 80 & d < 90)
            {
                return 'B';
            }
            else
                return 'A';
            ////Other Solution
            /////var s = (s1 + s2 + s3) / 3;
            //if (60 > s) return 'F';
            //if (70 > s) return 'D';
            //if (80 > s) return 'C';
            //if (90 > s) return 'B';
            //return 'A';
            //return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';
        }
        /////////////////////////////////////////////////////////////////////////////
        public static int Multiply(int x)
        {
            int numb = 0;
            if (x % 2 == 1)
                numb = x * 9;
            else
                if (x % 2 == 0)
                numb = x * 8;
            return numb;
            //Other Solution
           // public static int Multiply(int n) => n * (n % 2 == 0 ? 8 : 9);
        }
        public static int DontGiveMeFive(int start, int end)
        {
            int i = start;
            int count = 0;
            for (; i <= end; i++)
            {
                if (i.ToString().Contains("5") == false)

                    count++;
                return Enumerable.Range(start, end - start + 1)
                       .Where(x => !x.ToString().Contains("5"))
                       .Count();
            }
            return count;
            //OtherSolution
           // return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
        }
        /////////////////////////////////Sequence
        public static string ShowSequence(int n)
        {
            int sumInt = 0;
            string sum = "";
            for (int i = 0; i <= n; i++)
            {
                if (n == 0)
                {
                    sum += i + "=";
                }
                else if (n < 0)
                {
                    sum += n + "<";
                }
                else
               if (i == n)
                {
                    sum += i + " = ";
                }
                else
                    sum += i + "+";
                sumInt += i;
            }
            sum += sumInt;
            return sum;
        }
        public static string ReverseWords(string str)
        {
            var b = str.Split(' ');
            string s = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {
                s += b[i] + " ";
            }
            var x = s.Remove(s.Length - 1);
            return x;
            //Other Solution
            //return string.Join(" ", str.Split(' ').Reverse());
            //string[] words = str.Split(' ');
            //Array.Reverse(words);
            //return string.Join(" ", words);
        }
        public static int Number(List<int[]> peopleListInOut)
        {
            int sum1 = 0;
            int sum2 = 0;
            int lastvalue = 0;

            for (int i = 0; i < peopleListInOut.Count(); i++)
            {
                sum1 += peopleListInOut[i].First();
                sum2 += peopleListInOut[i].Last();
            }
            lastvalue = sum1 - sum2;
            if (lastvalue < 0)
            {
                return 0;
            }
            return lastvalue;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////Skladeczki i oprocentowania
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            while (principal < desiredPrincipal)
            {
                double oprocentowanieWSkaliRoku = ((principal * interest) - (principal * interest * tax));
                principal += oprocentowanieWSkaliRoku;
                years++;
            }
            Console.WriteLine("v YEARS WHAT YOU NEED v");
            return years;
            //other solution
            //return (int)Math.Ceiling(Math.Log(dp / p, 1 + (i * (1 - t))));
            //var years = 0;
            //while (Principal < DesiredPrincipal)
            //{
            //    Principal += Principal * Interest * (1 - Tax);
            //    years++;
            //}
            //return years;
        }
        /////////////////////////////////////////////////////////////2 Litery nie moga wystepowac kolo sb  
        public static bool IsIsogram(string str)
        {
            string b = str.ToLower();
            for (int i = 0; i < b.Length; i++)
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i] == b[j])
                        return false;
                }
            return true;
            //OtherSolution
            //var chars = str.ToLower().ToCharArray();
            //var hash = new HashSet<char>();

            //foreach (var c in chars)
            //{
            //    if (hash.Contains(c))
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        hash.Add(c);
            //    }
            //}
            //return str.ToLower().Distinct().Count() == str.Length;
            // => str.ToLower().Distinct().Count() == str.Length;
        }
        ////////////////////////////////////////////////////////////////////////tablica gdzie 2 = -2
        public static int[] InvertValues(int[] input)
        {
            //Other Solution
           // return input.Select(n => -n).ToArray();
           // for (int i = 0; i < input.Count(); i++) input[i] *= -1;
           // return input;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    input[i] = -input[i];
                }
                else if (input[i] < 0)
                {
                    input[i] = input[i] * (-1);
                }
                else
                {
                    input[i] = 0;
                }
            }
            return input;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////Operatorki
        public static double basicOp(char operation, double value1, double value2)
        {
            double x = 0;
            if (operation == '+')
            {
                return x = value1 + value2;
            }
            if (operation == '-')
            {
                return x = value1 - value2;
            }
            if (operation == '*')
            {
                return x = value1 * value2;
            }
            if (operation == '/')
            {
                return x = value1 / value2;
            }
        //    switch (op)
        //    {
        //        case '+': return val1 + val2;
        //        case '-': return val1 - val2;
        //        case '*': return val1 * val2;
        //        case '/': return val1 / val2;
        //    }
            return 0;
        //    return op == '+' ? val1 + val2
        //: op == '-' ? val1 - val2
        //: op == '*' ? val1 * val2
        //: val1 / val2;
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
            //Other Solution
         //   return (input == null || input.Length == 0) ? new int[0] : new int[] { input.Count(o => o > 0), input.Where(o => o < 0).Sum() };
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////XOxO Xo
        public static bool XO(string input)
        {
            int countx = 0;
            int county = 0;
            var b = input.ToLower().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length == 0)
                    return false;
                else
                    if (b[i] == 'x')
                    countx++;
                else if (b[i] == 'o')
                    county++;
            }
            if (countx == county)
                return true;
            return false;
        }
            //return false;
            //return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
            //string low = input.ToLower();
            //return low.Count(x => x == 'x') == low.Count(x => x == 'o');

            ///////////////////////////////////////////////////////FindNeedle
            public static string FindNeedle(object[] haystack)
            {
                int position = 0;
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] is string && haystack[i] == "needle")
                    {
                        Console.WriteLine("Hello niddle {0}", haystack[i]);
                        position += i;
                    }
                    else
                        continue;
                }
                return "found the needle at position " + position;
                //return "found the needle at position " + Array.IndexOf(haystack, "needle");
                //return string.Format("found the needle at position {0}", haystack.ToList().IndexOf("needle"));
            }
            
            //////////////////////////////////////////////////////////////////////////////FirstChar[R] + playingBanjo
            public static string AreYouPlayingBanjo(string name)
            {
                return name.Take(1).Contains('R') || name.Take(1).Contains('R') ? name + " playing banjo" : " does not playing banjo";
                //return string.Format("{0} {1} banjo", name, char.ToLower(name[0]) == 'r' ? "plays" : "does not play");
                //=> name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
            }
        /////////////////////////////////////////////////THeShortest string
        public static int FindShort(string s)
        {
            if (s.Length > 0)
            {
                string[] arr = s.Split(' ');
                int min = arr.Select(x => x.Length).Min();
                return min;
            }
            else
                return 0;
        }
        ////////////////////////////////////////////////////Istriangle
        public static bool IsTriangle(int a, int b, int c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return false;
            }
            else
            {
                if ((a <= 0) || (b <= 0) || (c <= 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
       
        
}
}
