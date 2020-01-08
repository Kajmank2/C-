using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestArray.GOLD
{
    public static class Gold
    {
        //////////////////////////////////////////////////Tower *
        public static string[] TowerBuilder(int nFloors)
        {
            string[] karolek = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
            {
                int spacenumb = nFloors - i - 1;
                string space = Gold.RepeatConcat(" ", spacenumb);
                int num = 2 * i + 1;
                string blocks = Gold.RepeatConcat("*", num);

                karolek[i] = space + blocks + space;
            }
            foreach (var item in karolek)
            {
                Console.WriteLine(item);
            }
            return karolek;
        }
        static string RepeatConcat(string s, int n)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }

        //////////////////////////////////////////////////// Position in alphabet a = 1,b=2
        public static string AlphabetPosition(string text)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var b = text.ToLower();
            string s = "";
            if (text.Length > 0)
            {
                for (int i = 0; i < b.Length; i++)
                    for (int j = 0; j < alphabet.Length; j++)
                    {

                        if (alphabet[j] == b[i])
                        {
                            s += ++j + " ";
                        }
                    }

                var x = s.TrimEnd(' ');
                return x;
            }
            else
                return "";
            //OtherSolution
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
        //////////////////////////////////////////////////////////////////// pierwszy string _ dodanie
        public static string PigLatin(string s)
        {
            string str = "";
            var v = s.Split(' ').ToArray();
            for (int i = 0; i < v.Length; i++)
            {
                string rev = "";
                var b = v[i].ToCharArray();

                for (int j = 1; j < b.Length; j++)
                {
                    rev += b[j];
                }
                str += rev + b[0] + "ay" + "*";

            }
            string strfinish = str.Remove(str.Length - 1);
            return strfinish;
            //Other Solutions
            //return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
            //return Regex.Replace(str, "(?<=^| )(\\w)(\\w+)", m => m.Groups[2].Value + m.Groups[1].Value + "ay");,  
            //return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
            //var words = str.Split(' ');
            //var sb = new StringBuilder();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    sb.Append(words[i].Substring(1));
            //    sb.Append(words[i][0]);
            //    sb.Append("ay ");
            //}

            //return sb.ToString().TrimEnd(' ');
        }
        /////////////////////////////////////////////////////////ROmanCONVERT
        public static string Solution(int n)
        {
            var decimalValue = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var romanNumeral = new string[]{
          "M",
          "CM",
          "D",
          "CD",
          "C",
          "XC",
          "L",
          "XL",
          "X",
          "IX",
          "V",
          "IV",
          "I"
        };
            var romanized = "";
            for (var index = 0; index < decimalValue.Length; index++)
            {
                while (decimalValue[index] <= n)
                {
                    romanized += romanNumeral[index];
                    n -= decimalValue[index];
                }
            }
            return romanized;
        }
        //=======================================================================================================Liczenie Smail :D :)
        public static int CountSmileys(string[] smileys)
        {
            string[] br = { ";]", ":[", ";*", ":$", ";-D" };
            int count = 0;
            //for (int i = 0; i < smileys.Length; i++)
            //{
            //    if (smileys[i].Length>1 && (smileys[i].Contains(":~") || smileys[i].Contains(":") || smileys[i].Contains(";-") || smileys[i].Contains(" ") ));
            //    if (smileys[i].Contains("D") || smileys[i].Contains(')'))
            //    {
            //        count++;
            //    }
            //}
            //for (int i = 0; i < smileys.Length; i++)
            //    for (int j = 0; j < br.Length; j++)
            //    {
            //    if (smileys[i]==br[j])
            //    {
            //        count++;
            //    }
            //}
            //return count;
            for (int i = 0; i < smileys.Length; i++)
            {
                if (smileys[i].Length == 2 & (smileys[i].Contains('D') || smileys[i].Contains(')')) & ((smileys[i].Contains(':') || smileys[i].Contains(';'))))
                {
                    count++;
                }
                if (smileys[i].Length == 3 & (smileys[i].Contains('D') || smileys[i].Contains(')')) & ((smileys[i].Contains(':') || smileys[i].Contains(';')) & (smileys[i].Contains('-') || smileys[i].Contains('~'))))
                {
                    count++;
                }
            }
            return count;
            //Other Solutions
            //    return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
            //    Regex.Matches(string.Join(" ", smileys), "([:;][-~]?)[)D]").Count;
            //          private static readonly Regex SmileyRegex = new Regex(@"^[:;][-~]?[)D]$");

            //public static int CountSmileys(string[] smileys)
            //{
            //    return smileys.Count(SmileyRegex.IsMatch);
            //}
            //int num = 0;
            //    for(int i=0; i<s.Length; ++i) {
            //      if(s[i].Length == 2) {
            //        if(s[i][0] == ':' || s[i][0] == ';')
            //          if(s[i][1] == ')' || s[i][1] == 'D')
            //            num = num + 1;
            //      } else if(s[i].Length == 3) {
            //        if(s[i][0] == ':' || s[i][0] == ';') 
            //          if(s[i][1] == '-' || s[i][1] == '~')
            //            if(s[i][2] == ')' || s[i][2] == 'D')
            //              num = num + 1;
            //      }
            //    }

            //    return num;
            //}
            //}
        }
        /////////////////////////////////////////////////////////Suma == Potega*Count
        public static bool Narcissistic(int value) //145
        {
            int Count(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                return n.ToString().Length;
            }
            int m = Count(value);
            int sum = 0;
            int x = value;
            while (x > 0)
            {
                sum += (int)Math.Pow(x % 10, m);
                x /= 10;
            }
            if (value == sum)
            {
                return true;
            }
            else
                return false;
            //Other Solution
            //var str = value.ToString();
            //return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
            //var lstInt = value.ToString().Select(x => int.Parse(x.ToString())).ToList();
            //double resultTemp = 0;

            //lstInt.ForEach(x =>
            //{
            //    resultTemp += Math.Pow(x, lstInt.Count);
            //});

            //return resultTemp == value;
            //string digits = value.ToString();
            //double sumOfPoweredDigits = 0;

            //foreach (char digit in digits)
            //{
            //    sumOfPoweredDigits += Math.Pow(Char.GetNumericValue(digit), digits.Length);
            //}

            //return (int)sumOfPoweredDigits == Int32.Parse(digits);

            //public static bool Narcissistic(int n) => n == n.ToString().ToCharArray().Aggregate(0, (s, d) => s + (int)Math.Pow(Int32.Parse(d.ToString()), n.ToString().Length));
        }
        //================================================================Sprawdzanie czy jest null  i czy zawiera niedozwolony znak
        public static bool Alphanumeric(string str)
        {

            char[] s = { '#', '@', '!', '$', '^', '&', '*', ')', '_', '+', '-', '=', '[', ' ', '\t', '"' };
            var k = str.ToCharArray();

            if (str == "")
            {
                return false;
            }
            else
                for (int i = 0; i < k.Length; i++)
                    for (int j = 0; j < s.Length; j++)
                        if (k[i] == s[j])
                            return false;
            return true;
            //Other Solution
            //public static bool Alphanumeric(string str) =>
            //new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
            //      public static bool Alphanumeric(string str)
            //      {
            //          return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
            //      }
            //      public static bool Alphanumeric(string s) => new Regex("^[a-zA-Z0-9]+$").IsMatch(s);
            //      public static bool Alphanumeric(string str) => IsMatch(str, @"^[a-zA-Z\d]+$");
            //      return str.All(char.IsLetterOrDigit) && !string.IsNullOrEmpty(str);
            //        => Regex.Match(str, @"^[\da-zA-Z]+$").Success;
        }
        // ==========================================================================================Number telefoniren
        public static string CreatePhoneNumber(int[] numbers)
        {
            string s = string.Join("", numbers);
            return string.Format("({0}) {1}-{2}",
                s.Substring(0, 3),
                s.Substring(3, 3),
                s.Substring(6));
            //Other Solution
            //  return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
            //  return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
            //  public static string CreatePhoneNumber(int[] numbers) =>
            //new Regex("(...)(...)(....)").Replace(String.Concat(numbers), "($1) $2-$3");
            // return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
            //  return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
            //return String.Format("{0:(000) 000-0000}", ulong.Parse(String.Join("", numbers)));
            //return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
        }
        // ==========================================================Stringi revers < 5=====================
        public static string wt(string sentence)
        {
            return new string(sentence.ToArray().Reverse().ToArray());
        }
        public static string SpinWords(string sentence)
        {
            //  new string(str.ToArray().Reverse().ToArray());

            string s = "";
            var sr = sentence.Split(' ');
            for (int i = 0; i < sr.Length; i++)
            {
                if (sr[i].Length >= 5)
                {
                    sr[i] = wt(sr[i]);
                }
            }
            String joined = String.Join(" ", sr);
            return joined;
            // return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));

        }
        //=================================================================Dicitionary ilosc literek i wystapienia ===============================================

        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            //    Dictionary<char, int> d = new Dictionary<char, int>();
            //    string str = "";
            //    d.Add('a', 2);
            //    d.Add('b', 2);
            //    foreach (KeyValuePair<char, int> kvp in d)
            //    {
            //        for (int i = 0; i < kvp.Value; i++)
            //        {
            //            str += kvp.Key.ToString();
            //        }
            //        Console.WriteLine(str);
            //    }
            //}
            //    Dictionary<char, int> d = new Dictionary<char, int>();
            //    d.Add('a', 2);
            //    foreach (KeyValuePair<char, int> kvp in d)
            //    {
            //        Console.WriteLine("key{0} , value ={1}", kvp.Key, kvp.Value);
            //    }
            //Console.WriteLine(Kata.Count("halko"));
            //    Dictionary<char, int>.ValueCollection valcoll = d.Values;
            //     foreach (var item in valcoll)
            //     {
            //         Console.WriteLine("value = {0}", item);
            //     }
        }
    }
}
