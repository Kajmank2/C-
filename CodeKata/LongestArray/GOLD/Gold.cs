using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestArray.GOLD
{
    public static class Gold
    {
//        The wave(known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed stadium when successive groups of spectators briefly stand, yell, and raise their arms.Immediately upon stretching to full height, the spectator returns to the usual seated position.
//The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats.In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd.When the gap in seating is narrow, the wave can sometimes pass through it.Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating waves have been produced. (Source Wikipedia)
        public static List<string> wave(string str)
        {
            List<string> ls = new List<string>();
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length)
                {
                    if (str[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        var xar = str[i].ToString().ToUpper();
                        var chhar = Convert.ToChar(xar);
                        StringBuilder ns = new StringBuilder(str);
                        ns.Remove(i, 1);
                        ns.Insert(i, chhar);
                        ls.Add(ns.ToString());
                    }
                }
            }

            return ls;
        }

        //    Define a function that takes an integer argument and returns logical value true or false depending on if the integer is a prime.
        //Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
        //Example
        //is_prime(1)  /* false */
        //is_prime(2)  /* true  */
        //is_prime(-1) /* false */
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
        //        You wrote all your unit test names in camelCase.But some of your colleagues have troubles reading these long test names.So you make a compromise to switch to underscore separation.

        //To make these changes fast you wrote a class to translate a camelCase name into an underscore separated name.

        //Implement the ToUnderscore() method.

        //Example:

        //"ThisIsAUnitTest" => "This_Is_A_Unit_Test"
        ////        Write Number in Expanded Form
        /// 
        public static string ToUnderScore(string name)
        {
            string up = "abcdefghijklmnopqrstuvwxyz01234567890".ToUpper();
            string number = "0123456789";
            string s = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i > 0)
                {

                    if (up.Contains(name[i]) & name[i - 1] != '_')
    
                        //& name[i - 1] != '0'
                        //& name[i - 1] != '1'
                        //& name[i - 1] != '2'
                        //& name[i - 1] != '3'
                        //& name[i - 1] != '4'
                        //& name[i - 1] != '5'
                        //& name[i - 1] != '6'
                        //& name[i - 1] != '7'
                        //& name[i - 1] != '8'
                        //& name[i - 1] != '9'

                    {
                        s += "_" + name[i];
                    }
                    else
                    {
                        s += name[i];
                    }
                }
                else
                    s += name[0];
            }

            return s;
        }


        //You will be given a number and you will need to return it as a string in Expanded Form.For example:

        //Kata.ExpandedForm(12); # Should return "10 + 2"
        //Kata.ExpandedForm(42); # Should return "40 + 2"
        //Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
        //NOTE: All numbers will be whole numbers greater than 0.

        //If you liked this kata, check out part 2!!
        public static string ExpandedForm(long num)
        {
            string s = "";
            var d = num.ToString();
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] - '0' > 0)
                {
                    s += d[i];
                    int zero = d.Length - 1 - i;
                    for (int j = 0; j < zero; j++)
                    {
                        s += "0";
                    }
                    s += " + ";
                }
            }
            return s.Substring(0, s.Length - 3);

            //    var str = num.ToString();
            //    return String.Join(" + ", str
            //        .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
            //        .Where(x => x > 0));
            //    string numString = num.ToString();
            //    string blah = "";
            //    for (int i = 0; i < numString.Length; i++)
            //    {
            //        if (numString[i] != '0')
            //        {
            //            blah += numString[i];
            //            blah += new String('0', numString.Length - i - 1);
            //            blah += " + ";
            //        }
            //    }
            //    return blah.Substring(0, blah.Length - 3);
            }
            public static char FindMissingLetter(char[] array)
        {
            char[] alphabetSmall = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alphabetBig = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();
            int start = 0;
            char[] alphabet;
            if (alphabetSmall.Contains(array[0]))
            {
                alphabet = alphabetSmall;
            }
            else
            {
                alphabet = alphabetBig;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == array[0])
                {
                    start = i;
                }
            }
            int arrayIndex = 0;
            for (int i = start; i < alphabet.Length; i++)
            {

                if (alphabet[i] != array[arrayIndex])
                {
                    return alphabet[i];
                }
                arrayIndex++;
            }
            return ' ';
            //public static char FindMissingLetter(char[] array) => (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));
        }
        public static int CountDeafRats(string town)
        {
            int count = 0;
            int x = Gold.CounDeafRatsLeft(town);
            int y = Gold.CounDeafRatsRight(town);
            count = x + y;
            return count;
            //var rats = town.Replace(" ", "").Split('P');
            //var leftCount = rats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
            //var rightCount = rats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');
            // return leftCount + rightCount;
        }
        public static int CounDeafRatsLeft(string town)
        {
            var Way = town.Split('P');
            var left = Way[0];
            var leftleft = left.ToString();
            var b = Gold.RemoveWhitespace(leftleft);
            int count = 0;
            for (int i = 0; i < b.Length; i += 2)
            {
                if (b[i] == 'O')
                {
                    count++;
                }
            }
            return count;

        }
        public static int CounDeafRatsRight(string town)
        {
            var Way = town.Split('P');
            var right = Way[1];
            var rightright = right.ToString();
            var b = Gold.RemoveWhitespace(rightright);
            int count = 0;
            for (int i = 0; i < b.Length; i += 2)
            {
                if (b[i] == '~')
                {
                    count++;
                }
            }
            return count;

        }
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        public static string CamelCase(this string str)
        {
            if (str.Length == 0)
            {
                return "";
            }

            var s = str.Split(' ');
            string final = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "")
                {
                    continue;
                }
                var rest = s[i].Remove(0, 1);
                var x = s[i].ToCharArray();
                final += x[0].ToString().ToUpper() + rest;

            }
            return final;
            //TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            //str = cultInfo.ToTitleCase(str);
            //str = str.Replace(" ", "");
            //return str;
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
            //var words = str.Split(' ');
            //var finalString = string.Empty;

            //foreach (var word in words)
            //{
            //    finalString += word.Length > 0 ? (word.Substring(0, 1).ToUpper() + word.Substring(1)) : string.Empty;
            //}

            //return finalString;
        }
        public static bool Scramble(string str1, string str2)
        {
            Func<string, Dictionary<char, int>> fun = s =>
               s.GroupBy(c => c)
               .Select(g => new { g.Key, Count = g.Count() })
               .ToDictionary(pair => pair.Key, pair => pair.Count);

            var map1 = fun(str1);
            var map2 = fun(str2);

            foreach (KeyValuePair<char, int> p2 in map2)
            {
                if (!map1.ContainsKey(p2.Key)) return false;

                if (map1[p2.Key] < p2.Value) return false;
            }


            return true;
            //Other Solution
            //return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
            //var possible = str1.ToList();

            //foreach (var c in str2)
            //{
            //    if (!possible.Remove(c))
            //        return false;
            //}

            //return true;
        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (result.Count(i => i == item) < x)
                    result.Add(item);
            }
            return result.ToArray();

            //var occurences = new Dictionary<int, int>();
            //var list = new List<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!occurences.ContainsKey(arr[i])) occurences.Add(arr[i], 1);
            //    else occurences[arr[i]]++;
            //    if (occurences[arr[i]] <= x) list.Add(arr[i]);
            //}
            //return list.ToArray();
            //public static int[] DeleteNth(int[] arr, int x)
            //{
            //    return arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();
            //}

        }
        //////////////////////////////////////////////////////////////////////////////////ENCRYPT 
        /// public static string Encrypt(string text, int n)
        //{
        //    if (n <= 0)
        //    {
        //        return text;
        //    }
        //    else
        //    {
        //        for (int j = n; j >= 1; j--)
        //        {
        //            string s = "";
        //string s2 = "";

        //            for (int i = 0; i<text.Length; i++)
        //            {
        //                if (i % 2 == 1)
        //                {
        //                    s += text[i];
        //                }
        //                else
        //                    s2 += text[i];
        //            }
        //            text = String.Concat(s, s2);
        //        }
        //        return text;
        //    }
        //}
        //    public static string Encrypt(string text, int n)
        //    {
        //        if (text == "" || text == null || n <= 0) { return text; } // Sanity Check

        //        string odd = "";
        //        string even = "";

        //        for (int i = 0; i < n; i++)
        //        {
        //            for (int j = 0; j < text.Length; j++)
        //            {
        //                switch (j % 2)
        //                {
        //                    case 0:
        //                        even += text[j];
        //                        break;
        //                    case 1:
        //                        odd += text[j];
        //                        break;
        //                    default:
        //                        Console.WriteLine("An error occurred.");
        //                        break;
        //                }
        //                //Console.WriteLine("Index: " + (j < 10 ? "0" + j.ToString() : j.ToString()) + " Char: " + text[j] + " Text: " + "Odd: " + odd + " Even: " + even);
        //            }//end encryption iteration
        //            text = odd + even;
        //            odd = even = "";
        //        }//end n times
        //        return text;
        //    }

        //    public static string Decrypt(string encryptedText, int n)
        //    {
        //        if (encryptedText == "" || encryptedText == null || n <= 0) { return encryptedText; } // Sanity Check

        //        int len = encryptedText.Length;
        //        string evenHalf = "";
        //        string oddHalf = "";

        //        for (int i = 0; i < n; i++)
        //        {
        //            evenHalf = encryptedText.Substring(0, len / 2);
        //            oddHalf = encryptedText.Substring(len / 2, (1 + len) / 2);
        //            //Console.WriteLine("\n    Decrypt Iteration " + i + "\n    Even String: " + evenHalf + "    Odd String: " + oddHalf);
        //            encryptedText = "";
        //            for (int j = 0; j < len; j++)
        //            {
        //                switch (j % 2)
        //                {
        //                    case 0:
        //                        encryptedText += oddHalf[0];
        //                        oddHalf = oddHalf.Substring(1);
        //                        break;
        //                    case 1:
        //                        encryptedText += evenHalf[0];
        //                        evenHalf = evenHalf.Substring(1);
        //                        break;
        //                    default:
        //                        Console.WriteLine("An error occurred.");
        //                        break;
        //                }
        //                //Console.WriteLine("Index: " + (j < 10 ? "0" + j.ToString() : j.ToString()) + " Char: " + encryptedText[j] + " Text: " + encryptedText + " Odd: " + oddHalf + " Even: " + evenHalf);
        //            } // end decrypt iteration    
        //        } // end n times
        //        return encryptedText;
        //    }
        //}
        //////////////////////////////////////////////Program Count digts >1
        public static int DuplicateCount(string str)
        {
            string s = "";
            var FreQ = from x in str.ToLower()
                       group x by x into y
                       select y;

            foreach (var ArrEle in FreQ)
            {
                if (ArrEle.Count() > 1)
                {
                    s += ArrEle.Key;
                }
            }

            return s.Length;
        }
    
            //    //Other Solution
            //  //  return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
            ////////////////////////////////////////////////////////Compare 2 Tables wchich are sqrt
            public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            var bb = b.Select(x => (double)x).ToArray();
            var z = bb.Select(y => Math.Sqrt(y));
            var aa = a.Select(x => (double)x).ToArray();
            bb = z.ToArray();
            Array.Sort(aa);
            Array.Sort(bb);
            return aa.SequenceEqual(bb);
            //if ((a == null) || (b == null))
            //{
            //    return false;
            //}

            //int[] copy = a.Select(x => x * x).ToArray();
            //Array.Sort(copy);
            //Array.Sort(b);

            //return copy.SequenceEqual(b);
            //if (a == null || b == null) return false;
            //var result = a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
            //return result;
        }
        ///////////////////////////////////////////Song DECODER - DELETE WUB IN STRING !
        public static string SongDecoder(string input)
        {

            String[] separatpr = { "WUB" };
            var inputAray = input.Split(separatpr, StringSplitOptions.RemoveEmptyEntries);
            string song = "";
            int totalCount = inputAray.Count();
            foreach (var item in inputAray)
            {
                if (inputAray.LastOrDefault().Equals(item))
                {
                    song += item;
                }
                else
                    song += item + " ";
            }
            return song;
        }
        //OTHER SOLUTION
        //return String.Join(" ", input.Split(new string[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries));
        //return Regex.Replace(input, @"(WUB)+", " ").Trim();
        //return Regex.Replace(input, "(WUB)+", " ").Trim();

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
       public static string RepeatConcat(string s, int n)
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
