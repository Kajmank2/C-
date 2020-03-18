using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Table_Del
{
    class Program
    {
        class KajmanException : Exception
        {
            public KajmanException(string msg) : base(msg)
            {

            }
        }

        public class Vector3D
        {
            private double x;
            private double y;
            private double z;
            public Vector3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Kajman.fiveStar(1));
            Console.WriteLine(Kajman.DigitDifferenceSort(new int[] {152,23,7,887,243 }));
            Console.WriteLine(Kajman.RemoveSmallest(new List<int>{ }));
            Console.WriteLine(Kajman.DigitalRoot(456));
            Console.WriteLine(Kajman.ReverseSeq(54321));
            Console.WriteLine(Kajman.AlphabetWar("ztztztzs"));
            Console.WriteLine(Kajman.StrCount("Hello", "o"));
            Kajman kajman = new Kajman();
            Console.WriteLine(kajman.wave("this Is a few words"));
            // Console.WriteLine(Kajman.wave("hello"));
            Console.WriteLine(Kajman.IsPrime(17));
            // Console.WriteLine(Kajman.ToUnderScore("This_IsKarolKa20"));
            Console.WriteLine(Kajman.ExpandedForm(7302));
            Console.WriteLine(Kajman.FindMissingLetter(new char[] { 'a', 'b', 'c', 'd', 'f' }));
            Console.WriteLine(Kajman.rowSumOddNumbers(42));
            //Console.WriteLine(Kajman.OddOrEven(new int[] { -1023, -1, 3 }));
            Console.WriteLine(Kajman.Solution("M"));
            Console.WriteLine(Kajman.NameShuffler("Jan Karol"));
            Console.WriteLine(Kajman.sumStrings("132111111231231231231", "9312333333333333333333"));
            //Console.WriteLine(Kajman.GetNumber("1234567898765"));
            //Console.WriteLine(Kajman.GetSum(1,2));
            // Console.WriteLine(Kajman.DigitalRoot(493193));
            // Console.WriteLine(Kajman.CountDeafRats("O~~OO~~OO~~OO~P~OO~~OO~~OO~~O"));
            // Console.WriteLine(Kajmans.GetVowelCount("abecadlo"));
            // Console.WriteLine(Kajmans.ToAlternatingCase("Hello Worlds"));
            //Console.WriteLine(Kajman.Range(5,10));
            //Console.WriteLine(Kajman.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            //Hi Evrybody 
            // Console.WriteLine(Kajman.formatDuration(132030240));
            //string s = Console.ReadLine();
            //Console.WriteLine(Kajmans.CamelCase(s));
            // Console.WriteLine(Kajman.SumArray(new double[] {1,3.0,2,3.5,5 }));
            // Console.WriteLine(Kajman.DeleteNth(new int[] {1,2,3,2,3,2},2));
            // Console.WriteLine(Kajman.Scramble("javscripts", "javascript"));
            // Console.WriteLine(Kajman.Decrypt(" Tah itse sits!", 4));
            // Console.WriteLine(Kajman.Oper(Kajman.HorMirror,""));
            // Console.WriteLine(Kajman.Bmi(12,23));
            // Console.WriteLine(Kajman.sayMeOperations("5 5 10"));
            // Console.WriteLine(Kajman.DuplicateCount("Indivisibilities"));
            // Console.WriteLine(Kajman.comp(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 }));
            // Console.WriteLine(Kajman.NextBiggerNumber(2017));
            // Console.WriteLine(Kajman.NextBiggerNumber(12));
            // Console.WriteLine(Kajman.SongDecoder("RWUBWUBWUBLWUB"));
            // Console.WriteLine(Kajman.DontGiveMeFive(4,17));
            // Console.WriteLine(Kajman.AlphabetPosition("0"));
            // Console.WriteLine(Kajman.GetUnique(new[] { 0, 0, 1, 0 }));
            // Console.WriteLine(Kajman.Accum("abcd"));
            // Console.WriteLine(Kajman.TowerBuilder(b));
            // Console.WriteLine(Kajman.Multiply(16));
            // Console.WriteLine(Kajman.NoNumerals("101"));
            // Console.WriteLine(Kajman.ValidParentheses("(())((()())())"));
            // Console.WriteLine(Kajman.ReverseWords("Hello World!"));
            // Console.WriteLine(Kajman.Litres(12.3));
            // Console.WriteLine(Kajman.Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));
            // Console.WriteLine(Kajman.CalculateYears(1000,0.05,0.18,1500));
            // Console.WriteLine(Kajman.IsIsogram("isogram"));
            // Console.WriteLine(Kajman.InvertValues(new int[]{0,1,2,3,-2,-3 }));
            // Console.WriteLine(Kajman.MSSG("1s2o3c4a5t6"));
            // Console.WriteLine(Kajman.PigLatin(s));
            // Console.WriteLine(Kajman.PigLatin("Pig latin is cool"));
            // Console.WriteLine(Kajman.Longest("aretheyheresssss", "yestheyarehere"));
            //Console.WriteLine(Kajman.AvgStr("Can you not do that?"));
            Console.ReadKey();
            // Console.WriteLine(Kajman.PigIt("ASd asd wee"));
            // Console.WriteLine(Kajman.CountPositivesSumNegatives(new int[] {0}));
            // Console.WriteLine(Kajman.PasswordValidator(s));
            // Console.WriteLine(Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            // Console.WriteLine(Kata.FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
            // Console.WriteLine(Kata.XO("xos"));
            // Console.WriteLine(Kata.AreYouPlayingBanjo("bravo"));
            // Console.WriteLine(Kata.Solution(12));
            // Console.WriteLine(Kata.Narcissistic(2));
            // Console.WriteLine(Kata.PasswordValidator("1$ololen"));
            // Console.WriteLine(Kata.testString("Knowledge"));
            // Console.WriteLine(Kata.FriendOrFoe( new string[] { "Ryan", "Kieran", "Mark", "Jimmy" }));
            // Console.WriteLine(Kata.NoSpace("     k  a t  b  "));
            // Console.WriteLine(Kata.SquareSum(new int[] { 5, 3, 4 }));
            // Console.WriteLine(Kata.Remove_char("Jasieniek"));
            // Console.WriteLine(Kata.FindNextSquare(144));
            // Console.WriteLine(Kata.findSum(5));
            // Console.WriteLine(Kata.Well(new string[] { "", "", "", "bad", "bad" }));
            // Console.WriteLine(Kata.SumMix(new object[] { 9, 3, "7", "3" }));
            // Console.WriteLine(Kata.repeatStr(10,"karol"));
            // Console.WriteLine(Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            // Console.WriteLine(Kata.Alphanumeric("\n\t\n"));
            // Console.WriteLine(Kata.Disemvowel("Wht r y,  cmmnst?"));
            // Console.WriteLine(Kata.ValidatePin("1234"));
            // Console.WriteLine(Kata.MakeComplement("112TAGC"));
            // Console.WriteLine(Kata.Check(new object[] { 80, 117, 115, 104,  85, 112, 115 }, 45));
            // Console.WriteLine(Kata.fiveStar(3));
            // Console.WriteLine(Kata.inArray(new string[] { "arp", "live", "strong" }, new string[] { "lively", "alive", "harp", "sharp", "armstrong" }));
            // Console.WriteLine(Kata.CreatePhoneNumber(new int[] {0,1,2,3,4,6,7,8,9}));
            // Console.WriteLine(Kata.Apple("20"));
            // Console.WriteLine(Kata.IsSquare(25));
            // Console.WriteLine(Kata.СenturyFromYear(2000));
            // Console.WriteLine(Kata.CountSheeps(new bool[] { true, false, true, false, true }));  
            // Console.WriteLine(Kata.MouthSize("ant bear"));
            // Console.WriteLine(Kata.SpinWords("karolas sw eda koskaasas"));
            // Kata.declareWinner(new Fighter("Lew", 22, 6), new Fighter("Harry", 10, 4), "Lew");
            // Remover.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 } );
            //  Console.WriteLine(Kata.Maps(new[] { 1, 2, 3 })); 
            //  Kata.summation(10);
            //  Console.WriteLine(Kata.FindShort("Karol to kozak"));
            //  Console.WriteLine(Kata.Opposite(2));   
            //  Console.WriteLine(Kata.MakeUpperCase(" saddsa dasad"));   
            // Console.WriteLine(Digitizer.Digitize(34));
            //Console.WriteLine(Kata.Solution("karol"));
            //Console.WriteLine(Kata.High("TO jest super String wwxq"));

        }
    }
}
public class Kajman
{

    public static string fiveStar(int number)
    {
        var x = number.ToString();
        x.Split().ToArray();
        string sum = "";
        if (x.Contains('3') || x.Contains('5'))
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '5')
                {
                    sum += "Star ";
                }
                else if (x[i] == '3')
                {
                    sum += "Five ";
                }
                else
                    sum += null;
            }
        }
        else
            return null;
        sum = sum.TrimEnd(' ');

        return sum;
    }
    public static int[] DigitDifferenceSort(int[] a)
    {
        List<int> ls = new List<int>();

        // Delte alone number
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 10)
            {
                a[i] = 0;
                ls.Add(a[i]);
            }
            else
            {
                ls.Add(a[i]);
            }
        }
        return a;
        //var seq = from x in ls orderby x where x= ls[0,0]
        //int newNumb;
        //public int[] DigitDifferenceSort(int[] a)
        //{
        //    return a.Reverse().OrderBy(x =>
        //    {
        //        string digits = x.ToString();
        //        return digits.Max() - digits.Min();
        //    }).ToArray();
            // True Digit
        //    List<string> l2 = ls.ConvertAll<string>(delegate (int i) { return i.ToString(); });
        //List<int> l3 = new List<int>();
        //foreach (var item in l2)
        //{

        //    newNumb = item[1] - item[0];
        //   Console.WriteLine(newNumb);
        //    l3.Add(newNumb);
        //}
        //foreach (var item in l2)
        //{
        //    Console.WriteLine(item);
        //}
        //// Sort List
        //l3.Sort();
        //foreach (var item in l3)
        //{
        //    Console.WriteLine(item);
        //}
        //return ls.ToArray();
    }


        public static List<int> RemoveSmallest(List<int> numbers)
    {
        List<int> aggre = new List<int>(numbers);
        if (numbers.Count >0)
        { 
        int minNumber = numbers.Min();
        aggre = new List<int>(numbers);

        foreach (var item in numbers)
        {
            if (item != minNumber)
            {
                aggre.Remove(minNumber);
                break;
            }
        }
        }
        return aggre;
    }
    public static int FindSmallestInt(int[] args)
    {
       return (int)args.Min();
    }
    public static int DigitalRoot(long n)
    {
        int sum = 0;
        var v = n.ToString().ToCharArray();
        for (int i = 0; i < v.Length; i++)
        {
            sum += (int)(v[i] - '0');
        }
        if (sum > 9)
            sum = Kajman.Loop(sum);
        return sum;
    }
    public static int Loop(int n)
    {
        int sum = 0;

        var vx = n.ToString().ToCharArray();
        for (int i = 0; i < vx.Length; i++)
        {
            sum += (int)(vx[i] - '0');
        }

        return sum;
    }

    //public static int DigitalRoot(long n)
    //{
    //    return (int)Kajman.Loop(n);
    //}
    //public static long Loop(long n)
    //{
    //    long sum = 0;
    //    var b = n.ToString().ToCharArray();
    //    for (int i = 0; i < b.Length; i++)
    //    {
    //        sum= (int)(b[i] - '0');
    //    }

    //    long sum = 0;
    //    for (long i = 0; i < longi.Length; i++)
    //    {
    //        sum += longi[i];
    //    }
    //    return sum;
    
    public static int[] ReverseSeq(int n)
    {
        int[] tab = new int[n];
        for (int i = n; i <=0 ; i--)
        {
            tab[i] = i;
        }

        return tab;
    }
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var retList = new List<T>();
            foreach (var element in iterable) if (!element.Equals(retList.LastOrDefault())) retList.Add(element);
            return retList;
        }
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
    public static string AlphabetWar(string fight)
    {
        int numbleft = 0;
        int numbright = 0;
        for (int i = 0; i < fight.Length; i++)
        {
            if (fight[i] == 'm' || fight[i] == 'q' || fight[i] == 'd' || fight[i] == 'z' || fight[i] == 'j')
            {
                switch (fight[i])
                {
                    case 'm':
                        numbright += 4;
                        break;
                    case 'q':
                        numbright += 3;
                        break;
                    case 'd':
                        numbright += 2;
                        break;
                    case 'z':
                        numbright += 1;
                        break;
                    case 'j':
                        numbright += 0;
                        break;
                }
            }
            else if (fight[i] == 'w' || fight[i] == 'p' || fight[i] == 'b' || fight[i] == 's' || fight[i] == 't')
            {
                switch (fight[i])
                {
                    case 'w':
                        numbleft += 4;
                        break;
                    case 'p':
                        numbleft += 3;
                        break;
                    case 'b':
                        numbleft += 2;
                        break;
                    case 's':
                        numbleft += 1;
                        break;
                    case 't':
                        numbleft += 0;
                        break;
                }
            }
        }
        if (numbleft > numbright)
            return "Left side wins!";
        else if (numbright > numbleft)
            return "Right side wins!";
        else
            return "Let's fight again!";
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

    public List<string> wave(string str)
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
    public static int RentalCarCost(int d)
    {
        if (d < 3)
        {
            return d * 40;
        }
        else if (d < 7)
        {
            return d * 40 - 20;
        }
        else
            return d * 40 - 50;
    }
    public static int OtherAngle(int a, int b)
    {
        return 180 - a - b;
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

    // 12  , , , , _if exsist do no create
    //public static string ToUnderScore(string name)
    //{
    //    string up = "abcdefghijklmnopqrstuvwxyz01234567890".ToUpper();
    //    string number = "0123456789";
    //    string s = "";
    //    for (int i = 0; i < name.Length; i++)
    //    {
    //        if (i > 0)
    //        {

    //            if (up.Contains(name[i]) & name[i - 1] != '_' 

    //                    //& name[i - 1] != '0'
    //                    //& name[i - 1] != '1'
    //                    //& name[i - 1] != '2'
    //                    //& name[i - 1] != '3'
    //                    //& name[i - 1] != '4'
    //                    //& name[i - 1] != '5'
    //                    //& name[i - 1] != '6'
    //                    //& name[i - 1] != '7'
    //                    //& name[i - 1] != '8'
    //                    //& name[i - 1] != '9'

    //            {
    //                s += "_" + name[i];
    //            }
    //            else
    //            {
    //                s += name[i];
    //            }
    //        }
    //        else
    //            s += name[0];
    //    }

    //    return s;
    //}
    //"ThisIsAUnitTest" => "This_Is_A_Unit_Test"
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
        //}
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
        int arrayindex = 0;
        for (int i = start; i < alphabet.Length; i++)
        {

            if (alphabet[i] != array[arrayindex])
            {
                return alphabet[i];
            }
            arrayindex++;
        }
        return ' ';
        //public static char FindMissingLetter(char[] array) => (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));
    }
    public static int BreakChocolate(int n, int m)
    {
        int mult = n * m;
        if (mult == 0 || mult == 1)
        {
            return 0;
        }
        else
        {
            return mult - 1;
        }
        return mult;
    }
    public static long rowSumOddNumbers(long n)
    {
        return (long)Math.Pow(n, 3);
    }
    public static string[] Solution(string str)
    {
        string ss = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (i % 2 == 0)
            {
                ss += str[i];
            }
            else
                ss += str[i] + " ";
        }
        if (ss.Length % 2 != 0)
        {
            ss += "_";
        }
        Console.WriteLine(ss);
        ss = ss.TrimEnd(' ');
        var table = ss.Split(' ').ToArray();
        return table;
    }
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
    public static string sumStrings(string a, string b)
    {
        var aa = Convert.ToDecimal(a);
        var bb = Convert.ToDecimal(b);
        decimal sum = aa + bb;
        return sum.ToString();
    }
    //public static int GetNumber(string str)
    //{
    //    return Enumerable.Range(0, str.Length - 4).Select(i => Convert.ToInt32(str.Substring(i, 5))).ToList().Max();
    //}

    //public static int DigitalRoot(long n)
    //{
    //   return (int)Kajman.Infinity(n);
    //}
    //public static long[] Loop(long n)
    //{
    //    var lent = n.ToString().Length;
    //    var longi = new long[lent];
    //    var b = n.ToString().ToCharArray();
    //    for (int i = 0; i < longi.Length; i++)
    //    {
    //        longi[i] = (int)(b[i] - '0');
    //    }
    //    return longi;
    //}
    //public static long Infinity(long n)
    //{
    //    long sum = 0;
    //    long sum2 = 0;
    //    long x = 0;
    //    var longi = Kajman.Loop(n);
    //    for (long i = 0; i < longi.Length; i++)
    //    {
    //        sum += longi[i];
    //    }
    //    if (sum > 10)
    //    {
    //        var longi2 = Kajman.Loop(sum);
    //        return Kajman.Infinity2(longi2);
    //    }
    //    return sum;
    //}
    //public static long Infinity2(long n)
    //{
    //    long sum = 0;
    //    var longi = Kajman.Loop(n);
    //    for (long i = 0; i < longi.Length; i++)
    //    {
    //        sum += longi[i];
    //    }
    //    return sum;
    //}
    public static int CountDeafRats(string town)
    {
        int count = 0;
        int x = Kajman.CounDeafRatsLeft(town);
        int y = Kajman.CounDeafRatsRight(town);
        count = x + y;
        return count;
    }
    public static int CounDeafRatsLeft(string town)
    {
        var Way = town.Split('P');
        var left = Way[0];
        var leftleft = left.ToString();
        var b = Kajman.RemoveWhitespace(leftleft);
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
        var b = Kajman.RemoveWhitespace(rightright);
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
    //var rats = town.Replace(" ", "").Split('P');
    //var leftCount = rats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
    //var rightCount = rats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');
    // return leftCount + rightCount;
    public static int GetAverage(int[] marks) => (int)marks.Average();

    public static int[] Range(int startnum, int endNum)
    {
        var table = new int[++endNum];
        string s = "";
        int[] table2 = new int[] { };
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = i;
            Console.WriteLine(table);
        }
        for (int i = 0; i < table.Length; i++)
        {
            if (table[i] >= startnum & table[i] <= endNum)
            {
                s += table[i] + " ";
            }
        }
        s = s.TrimEnd(' ');
        var x = s.Split(' ');
        var b = x.ToArray();
        var myint = Array.ConvertAll(b, int.Parse);
        return myint;
    }
    public static int[] minMax(int[] lst)
    {
        List<int> list = new List<int>();
        Array.Sort(lst);
        int a = lst.First();
        int b = lst.Last();
        list.Add(a);
        list.Add(b);
        return list.ToArray();
    }
    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
        {
            return "now";
        }
        else if (seconds == 1)
        {
            return "1 second";

        }
        else if (seconds > 0 & seconds < 60)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string formatted = string.Format(CultureInfo.CurrentCulture,
                    "{0} seconds", t.Seconds);
            return Kajman.NoPrular(formatted);
        }
        else if (seconds >= 60 & seconds < 3600)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string formatted = string.Format(CultureInfo.CurrentCulture,
                    "{0} minutes and {1} seconds", t.Minutes, t.Seconds);

            if (t.Seconds == 0)
            {
                formatted = string.Format(CultureInfo.CurrentCulture,
                    "{0} minutes", t.Minutes);
            }
            return Kajman.NoPrular(formatted);
        }
        else if (seconds >= 3600 & seconds < 86400)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string formatted = string.Format(CultureInfo.CurrentCulture,
                    "{0} hours, {1} minutes and {2} seconds", t.Hours, t.Minutes, t.Seconds);
            return Kajman.NoPrular(formatted);
        }
        else if (seconds >= 2629743 & seconds < 31556926)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string formatted = string.Format(CultureInfo.CurrentCulture,
                    "{0} days, {1} hours, {2} minutes and {3} seconds", t.Days, t.Hours, t.Minutes, t.Seconds);
            return Kajman.NoPrular(formatted);
        }
        else
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string formatted = string.Format(
             CultureInfo.CurrentCulture,
             "{0} years, {1} days, {2} hours, {3} minutes and {4} seconds",
             t.Days / 365,
             (t.Days - (t.Days / 365) * 365),
             t.Hours,
             t.Minutes,
             t.Seconds);
            return Kajman.NoPrular(formatted);
        }
    }
    public static string NoPrular(string formatted)
    {
        var str = formatted.Split(' ');
        string b = "";
        string s = "";
        string cb = "";
        for (int i = 0; i < str.Length; i++)
        {
            // FOR PLURAR 
            string bad = "";
            b += str[i] + " ";
            if (str.Length <= 2 & str[i] == "seconds")
            {
                b += str[++i].TrimEnd('s');
            }

            else if (str[i] == "1")
            {
                b = b + str[++i].Replace("s,", ", ");
            }

        }
        b = b.TrimEnd(' ');
        var x = b.Split(' ');
        for (int j = 0; j < x.Length; j++)
        {
            if (x[j] == "0")
            {
                if (x[j - 1] == "and")
                {
                    cb += x[j - 1];
                }
                cb += x[j] + x[j++];
            }
            else
                s += str[j] + " ";
        }

        s = s.TrimEnd(' ');
        s = s.TrimEnd('d');
        s = s.TrimEnd('n');
        s = s.TrimEnd('a');
        var ss = s.Split(' ').ToArray();
        Kajman k = new Kajman();

        return k.Arriks(ss);

    }
    public string Arriks(string[] x)
    {
        string xx = "";
        if (x[x.Length - 2] == "and")
        {
            x[x.Length - 2].Insert(x.Length - 3, "and");
        }
        else
            return x.ToString();
        return xx;
    }
    public static string Zero(string formatted)
    {
        var str = formatted.Split(' ');
        string s = "";
        string bad = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == "0")
            {
                if (str[i - 1] == "and")
                {
                    bad += str[i - 1];
                }
                bad += str[i] + str[i++];
            }
            else
                s += str[i];
            s = s.TrimEnd(' ');
            s = s.TrimEnd('d');
            s = s.TrimEnd('n');
            s = s.TrimEnd('a');
        }
        return s;
    }
}
///////////////////////////////////////////////////////////Array sum
//public static double SumArray(double[] array)
//{
//   var b= array.ToList();
//    double sum = 0;
//    if (array.Length == 0)
//    {
//        return 0;
//    }
//    else
//    {
//       sum = b.Sum();
//    }
//    return sum;
// return array.Sum();
//}
////////////////////////////////////////////////////////////////////////////// s1 == s2 
//public static bool Scramble(string str1, string str2)
//{
//    Func<string, Dictionary<char, int>> fun = s =>
//       s.GroupBy(c => c)
//       .Select(g => new { g.Key, Count = g.Count() })
//       .ToDictionary(pair => pair.Key, pair => pair.Count);

//    var map1 = fun(str1);
//    var map2 = fun(str2);

//    foreach (KeyValuePair<char, int> p2 in map2)
//    {
//        if (!map1.ContainsKey(p2.Key)) return false;

//        if (map1[p2.Key] < p2.Value) return false;
//    }


//    return true;
//    //Other Solution
//    //return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
//    //var possible = str1.ToList();

//    //foreach (var c in str2)
//    //{
//    //    if (!possible.Remove(c))
//    //        return false;
//    //}

//    //return true;
//}

// public static int[] DeleteNth(int[] arr, int x)
//  {
//var result = new List<int>();
//foreach (var item in arr)
//{
//    if (result.Count(i => i == item) < x)
//        result.Add(item);
//}
//return result.ToArray();

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

//  }
//public static string Encrypt(string s, int n)
//{
//    if (s == null) return s;
//    while (n-- > 0)
//    {
//        s = string.Join("", s.Where((x, i) => i % 2 == 1)) + string.Join("", s.Where((x, i) => i % 2 == 0));
//    }
//    return s;
//}

//public static string Decrypt(string s, int n)
//{
//    if (s == null) return s;
//    while (n-- > 0)
//    {
//        var len = s.Length / 2;
//        string s1 = s.Substring(0, len), s2 = s.Substring(len), rs = "";
//        for (int i = 0; i < len; i++) rs += "" + s2[i] + s1[i];
//        s = (s.Length % 2 == 0) ? rs : rs + s[s.Length - 1];
//    }
//    return s;
//}
//public static string Encrypt(string text, int n)
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
//            string s2 = "";

//            for (int i = 0; i < text.Length; i++)
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

//public static string Decrypt(string encryptedText, int n)
//{
//    if (encryptedText == "" || encryptedText == null || n <= 0) { return encryptedText; } // Sanity Check

//    int len = encryptedText.Length;
//    string evenHalf = "";
//    string oddHalf = "";

//    for (int i = 0; i < n; i++)
//    {
//        evenHalf = encryptedText.Substring(0, len / 2);
//        oddHalf = encryptedText.Substring(len / 2, (1 + len) / 2);

//        for (int j = 0; j < len; j++)
//        {
//            switch (j % 2)
//            {
//                case 0:
//                    encryptedText += oddHalf[0];
//                    oddHalf = oddHalf.Substring(1);
//                    break;
//                case 1:
//                    encryptedText += evenHalf[0];
//                    evenHalf = evenHalf.Substring(1);
//                    break;
//                default:
//                    Console.WriteLine("An error occurred.");
//                    break;
//            }
//        }
//        return encryptedText;
//    }
//    return encryptedText;
//if (n <= 0)
//{
//    return encryptedText;
//}
//else
//{
//    {
//        string s = "";
//        string s2 = "";

//        for (int i = 0; i < encryptedText.Length; i++)
//        {
//            if (i % 2 == 1)
//            {
//                s2 += encryptedText[i];
//            }
//            else
//                s += encryptedText[i];
//        }
//        encryptedText = String.Concat(s2, s);
//    }
//    return encryptedText;

/////////////////////////////////////////////////////////VertMirror
//public static string VertMirror(string strng)
//{
//    string[] separator = new string[] { "\n" };
//    string[] str = strng.Split(separator, StringSplitOptions.None);
//    string s = "";
//    foreach (var item in str)
//    {
//        item.Reverse();
//        s += item + @"\n";
//    }
//    s = s.TrimEnd(new[] { '\\', 'n' });
//    return s;
//}
//public static string HorMirror(string strng)
//{
//    string[] separator = new string[] { "\n" };
//    string[] str = strng.Split(separator, StringSplitOptions.None);
//    var b = str.Reverse();
//    string s = "";
//    foreach (var item in b)
//    {
//        s += item + @"\n";
//    }
//    s = s.TrimEnd(new[] { '\\', 'n' });
//    return s;
//}

//public static string Oper(Func<string,string> func, string s)
//{
//    return func(s);
//}
//public static string VertMirror(string strng)
//{
//    return string.Join("\n", strng.Split('\n').Select(i => string.Concat(i.Reverse())));
//}
//public static string HorMirror(string strng)
//{
//    return string.Join("\n", strng.Split('\n').Reverse());
//}
//public static string Oper(Func<string, string> fct, string s)
//{
//    return fct(s);
//}
//public static string Bmi(double weight, double height)
//{
//    double bmi = weight / Math.Pow(height,2);
//    return bmi <= 18.5 ? "Underweight" : bmi <= 25.0 ? "Normal" : bmi <= 30.0 ? "Overweight" : "Obese";
//}
//public static string sayMeOperations(string stringNumbers)
//{

//int x = 0;
//int add = 0;
//int multi = 0;
//int sub = 0;
//int divi = 0;
//int z = 0;
//var v = stringNumbers.Split(' ').ToArray();
//var list = stringNumbers.Split(' ').ToList();
//string s = "";

//for (int i = 0; i < v.Length; i++)
//{
//    int j = i + 1;
//    int k = i + 2;
//    if (k == v.Length)
//    {
//        break;
//    }
//    x = int.Parse(v[i]);
//    z = int.Parse(v[j]);
//    add = x + z;
//    multi = x * z;
//    sub = x - z;
//    divi = x / z;

//    if (add == int.Parse(v[k]))
//    {
//        s += "addition, ";
//    }
//    else if (sub == int.Parse(v[k]))
//    {
//        s += "subtraction, ";
//    }
//    else if (multi == int.Parse(v[k]))
//    {
//        s += "multiplication, ";
//    }
//    else if (divi == int.Parse(v[k]))
//    {
//        if (int.Parse(v[i]) != 0)

//            s += "division, ";
//    }
//}


//s = s.Remove(s.Length - 2, 2);
//return s;
// List<int> l = s.Split(' ').Select(Int32.Parse).ToList();
//   return String.Join(", ", Enumerable.Range(0, l.Count - 2).Select(i => l[i] + l[i + 1] == l[i + 2] ? "addition" : l[i] - l[i + 1] == l[i + 2] ? "subtraction" : l[i] * l[i + 1] == l[i + 2] ? "multiplication" : "division"));
//string buffer = "";
//int n1 = 0;
//int n2 = 0;
//int n3 = 0;
//string[] numbers = stringNumbers.Split(' ');
//for (int i = 0; i < numbers.Length - 2; i++)
//{
//    n1 = Convert.ToInt32(numbers[i]);
//    n2 = Convert.ToInt32(numbers[i + 1]);
//    n3 = Convert.ToInt32(numbers[i + 2]);
//    if ((n1 + n2) == n3)
//        buffer += "addition";
//    else if ((n1 - n2) == n3)
//        buffer += "subtraction";
//    else if ((n1 * n2) == n3)
//        buffer += "multiplication";
//    else
//        buffer += "division";
//    if (i != numbers.Length - 3)
//        buffer += ", ";
//}
//return buffer;




//public static int DuplicateCount(string str)
//{
//    string s = "";
//    var FreQ = from x in str.ToLower()
//               group x by x into y
//               select y;

//    foreach (var ArrEle in FreQ)
//    {
//        if ( ArrEle.Count() > 1)
//        {
//            s += ArrEle.Key;
//        }
//    }

//    return s.Length;
//    //Other Solution
//  //  return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
//for (int i = 0; i < str.Length; i++)
//{
//    if (str.Contains(str[i]))
//    {
//        s += str[i];
//        Console.WriteLine(s);
//    }
//}


//public static bool AreTablesTheSame(DataTable tbl1, DataTable tbl2)
//{
//    if (tbl1.Rows.Count != tbl2.Rows.Count || tbl1.Columns.Count != tbl2.Columns.Count)
//        return false;


//    for (int i = 0; i < tbl1.Rows.Count; i++)
//    {
//        for (int c = 0; c < tbl1.Columns.Count; c++)
//        {
//            if (!Equals(tbl1.Rows[i][c], tbl2.Rows[i][c]))
//                return false;
//        }
//    }
//    return true;
//}

//public static long NextBiggerNumber(long n)
//{
//if (n > 9)
//{
//    string mystr = n.ToString();
//    char right = mystr[mystr.Length - 1];
//    char middle = mystr[mystr.Length - 2];
//    char left=' ';
//    if (n>99)
//    {
//       left = mystr[mystr.Length - 3];
//    }
//    var sumRight = right + "" + middle;
//    var OneCHecksumRight = long.Parse(sumRight);
//    var sumLeft = left + "" + middle;
//    var OneCHeckSumLeft = long.Parse(sumLeft);
//    long finishleft=0;
//    long finishRight = 0 ;

//        var d = mystr.Remove(mystr.Length - 2, 2);
//        var builder = new StringBuilder();
//        builder.Append(d);
//        builder.Append(sumRight);
//        d = builder.ToString();
//        finishRight = long.Parse(d);

//    if (n > 99)
//    {
//        var lastRight = mystr[mystr.Length - 1];
//        var x = mystr.Remove(mystr.Length - 3, 3);
//        var builder2 = new StringBuilder();
//        builder2.Append(x);
//        builder2.Append(lastRight);
//        builder2.Append(sumLeft);
//        x = builder2.ToString();
//        finishleft = long.Parse(x);
//    }
//    if (n> finishleft & n> finishRight)
//    {
//        return -1;
//    }else
//    if (finishleft > finishRight)
//        return finishleft;
//    else
//        return finishRight;
//}
//return -1;

// public static long NextBiggerNumber(long n)
// {
//        var arr = n.ToString();
//        var y= arr.ToCharArray();
//        var x = arr.Length;

//      return  Kajman.findNext(y, x);
//}
//    public static void swap(char[] ar, int i, int j)
//        {
//            char temp = ar[i];
//            ar[i] = ar[j];
//            ar[j] = temp;
//        }
//     public   static long findNext(char[] ar, int n)
//        {
//            int i;
//        string s = "";
//            for (i = n - 1; i > 0; i--)
//            {
//                if (ar[i] > ar[i - 1])
//                {
//                    break;
//                }
//            }

//            if (i == 0)
//            {
//            return -1;
//            }
//            else
//            {
//                int x = ar[i - 1], min = i;
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (ar[j] > x && ar[j] < ar[min])
//                    {
//                        min = j;
//                    }
//                }

//                swap(ar, i - 1, min);

//                Array.Sort(ar, i, n - i);
//                for (i = 0; i < n; i++)
//                   s+=ar[i];
//            var finish = long.Parse(s);
//            return finish;
//            }
//        }
//    }
///////////////////////////////////////////Song DECODER - DELETE WUB IN STRING !
//public static string SongDecoder(string input)
//{

//String[] separatpr = {"WUB"};     
//var inputAray = input.Split(separatpr, StringSplitOptions.RemoveEmptyEntries);
//string song = "";
//int totalCount = inputAray.Count();
//foreach (var item in inputAray)
//{
//    if (inputAray.LastOrDefault().Equals(item))
//    {
//        song += item;
//    }else
//    song += item+ " ";          
//}
//return song;
////OTHER SOLUTION
//return String.Join(" ", input.Split(new string[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries));
//return Regex.Replace(input, @"(WUB)+", " ").Trim();
//return Regex.Replace(input, "(WUB)+", " ").Trim();
//}

//////////////////////////////////////////////////////////////////////
//public static bool IsUpperCase(this string text)
//{
//    if (text.Length==0)
//    {
//        return true;
//    }
//    var b = text.ToUpper();
//    for (int i = 0; i < text.Length; i++)
//    {
//        if (text == b )
//        {
//            return true;
//        }
//    }
//    return value.ToUpper() == value;
//    return !s.Any(x => Char.IsLower(x));
//    return !str.Any(x => char.IsLower(x));
//    return false;
//}
/////////////////////////////////////////////////////////////////////////////////////////////////grade == alphabet
//  public static char GetGrade(int s1, int s2, int s3)
// {

//double d = (s1 + s2 + s3) / 3;
//if (d >= 0 & d < 60)
//{
//    return 'F';
//}
//else if (d >= 60 & d < 70)
//{
//    return 'D';
//}
//else if (d >= 70 & d < 80)
//{
//    return 'C';
//}
//else if (d >= 80 & d < 90)
//{
//    return 'B';
//}
//else
//    return'A';
//var s = (s1 + s2 + s3) / 3;
//if (60 > s) return 'F';
//if (70 > s) return 'D';
//if (80 > s) return 'C';
//if (90 > s) return 'B';
//return 'A';
//return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';

//return 'F';
//   }
/////////////////////////////////////////////////////////////////////////////////Budowanie 
//public static string[] TowerBuilder(int nFloors)
//{
//    string[] karolek = new string[nFloors];
//    for (int i = 0; i < nFloors; i++)
//    {
//        int spacenumb = nFloors - i - 1;
//        string space = Kajman.RepeatConcat(" ", spacenumb);
//        int num = 2 * i + 1;
//        string blocks = Kajman.RepeatConcat("*", num);

//        karolek[i] = space + blocks + space;
//    }
//    foreach (var item in karolek)
//    {
//        Console.WriteLine(item);
//    }
//    return karolek;
//}
//static string RepeatConcat(string s, int n)
//{
//    return String.Concat(Enumerable.Repeat(s, n));
//}
/////////////////////////////////////////////////////////////////////////////////DRIVING LICENSE !
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
//public static int Multiply(int x)
//{
//    int numb = 0;
//    if (x%2 == 1)
//        numb = x * 9;
//    else
//        if (x % 2 == 0)
//        numb  = x*8;
//    return numb;
//    public static int Multiply(int n) => n * (n % 2 == 0 ? 8 : 9);
//}

//        public static int DontGiveMeFive(int start, int end)
//    {

//   int i = start;
//    int count = 0;
//    for (; i <= end; i++)
//    {
//        if (i.ToString().Contains("5") == false)

//        count++;
//        return Enumerable.Range(start, end - start + 1)
//               .Where(x => !x.ToString().Contains("5"))
//               .Count();
//    }
//    return count;
//}
//   return Enumerable.Range(start, end-start+1).Count(x => !x.ToString().Contains("5"));
////////////////////////////////////////////////////////////////////////////////Alphabet position 
//public static string AlphabetPosition(string text)
//{
//    char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
//    var b = text.ToLower();
//    string s = "";
//    if (text.Length > 0)
//    {
//        for (int i = 0; i < b.Length; i++)
//            for (int j = 0; j < alphabet.Length; j++)
//            {

//                if (alphabet[j] == b[i])
//                {
//                    s += ++j + " ";
//                }
//            }

//        var x = s.TrimEnd(' ');
//        return x;
//    }
//    else
//        return s;
//}
/////////////////////////////////////////////////////////////////Unique Number
//public static int GetUnique(IEnumerable<int> numbers)
//{
//    //var b = numbers.ToArray();
//    // b.OrderByDescending(x => x);
//    // string s = "";
//    // for (int i = 0; i < b.Length; i++)
//    // {
//    //     int nums = b[0];
//    //     if (b[i] != b[b.Length - 1] & b[b.Length - 1] != b[0])
//    //           return b[i];
//    // }
//    // return 1;
//    int[] array;
//  var b=  numbers.ToArray();
//    numbers.OrderBy(x => x);

//    return (b[0] != b[1] ? b[0] : b.Reverse());
//}

//public static string ShowSequence(int n) /////////////////////////////////////////////////////////////////////Sequence
//{
//    //int sumInt = 0;
//    //string sum = "";
//    //for (int i = 0; i <= n; i++)
//    //{
//    //    if (n == 0)
//    //    {
//    //        sum += i + "=";
//    //    }
//    //    else if (n < 0)
//    //    {
//    //        sum += n + "<";
//    //    }
//    //    else
//    //   if (i == n)
//    //    {
//    //        sum += i + " = ";
//    //    }
//    //    else
//    //        sum += i + "+";
//    //    sumInt += i;
//    //}
//    //sum += sumInt;
//    //return sum;
//    if (n < 0) return $"{n}<0";
//    if (n == 0) return "0=0";

//    IEnumerable<int> sequence = Enumerable.Range(0, n + 1);

//    return $"{String.Join("+", sequence)} = {sequence.Sum()}";
//    if (n < 0)
//        return n + "<0";
//    if (n == 0)
//        return "0=0";
//    int sum = 0;
//    StringBuilder sequence = new StringBuilder("0");
//    for (int i = 1; i <= n; i++)
//    {
//        sequence.Append("+" + i);
//        sum += i;
//    }
//    sequence.Append(" = " + sum);
//    return sequence.ToString();
//    return n == 0 ? "0=0" : n < 0 ? $"{n}<0" : string.Join("+", Enumerable.Range(0, n + 1)) + " = " + (n * (n + 1) / 2);


//public static String Accum(string s)
//{
//string sum = "";
//for (int i = 0; i < s.Length; i++)
//{
//    sum = s.ToUpper()  + "-";
//}
//return sum;
//string ans = "";
//int i = 0;
//while (i <s.Length)
//{
//    int n = 0;
//    while (n<i+1)
//    {
//        if (n==0)
//        {
//            ans += s[i].;
//        }
//    }
//}
//String result = "";
//for (int i = 0; i < s.length(); i++)
//{
//    char currentChar = s.charAt(i);
//    for (int j = 0; j <= i; j++)
//    {
//        if (j == 0)
//        {
//            result += Character.toUpperCase(currentChar);
//        }
//        else
//        {
//            result += Character.toLowerCase(currentChar);
//        }
//    }
//    result += "-";
//}
//return result.substring(0, result.length() - 1);
//    ans = ''
//i = 0
//while i < len(s):
//	n = 0

//    while n < i + 1:
//		if n == 0:
//			ans += s[i].upper()

//        else:
//			ans += s[i].lower()

//        n += 1

//    ans += '-'

//    i += 1
//return ans[:len(ans) - 1]

///////////////////////////////////////////////////////////////////////////////////////////////////////////// 10 - ten No numerals
//public static string NoNumerals(string str)
//{
//    //Kajman k = new Kajman();
//    //str = k.Ten(str);
//    //Console.WriteLine(str);
//    return str.Replace("10", "ten").Replace("0", "zero").Replace("2", "two").Replace("3", "three").Replace("4", "four").Replace("5", "five").Replace("6", "six")
//        .Replace("7", "seven").Replace("8", "eight").Replace("9", "nine").Replace("1", "one").Replace("10","ten");
//}
//public string Ten(string str)
//{
//    string x = "";
//    for (int i = 0; i < str.Length; i++)
//    {
//        if (str[i] == '1')
//        {
//            if (str[++i] == '0')
//            {
//                x = str.Replace("10", "ten");
//            }
//        }
//        else
//            x = str;
//    }
//    return x;
//}

//////////////////////////////////////////////////////////////////////////////////// chech valid ()()
//public static bool ValidParentheses(string input)
//{
//    var indent = 0;


//    for (var i = 0; i < input.Length && indent >= 0; i++)
//    { //indent>=0 is critical
//        indent += (input[i] == '(') ? 1 : -1;
//    }

//    return (indent == 0);
//int licznik1 = 0;
//int licznik2 = 0;
//for (int i = 0; i < input.Length; i++)
//{
//    if (input[0] == '(' )
//    {
//        if (/*input[i] ==('(') || input[i] ==(')') &*/ (0<=input.Length && input.Length<=100))
//        {

//            if (input[i] == '(')
//            {
//                licznik1++;
//            }
//            else if (input[i] == ')')
//            {
//                licznik2++;
//            }
//        }
//        else
//            return false;
//    }
//    else
//        return false;
//}
//if (licznik1 == licznik2)
//{
//    return true;
//}
//return false;
//public static string ReverseWords(string str)
//{
//    var b = str.Split(' ');
//    string s = "";
//    for (int i = b.Length-1; i >= 0; i--)
//    {
//        s += b[i] + " ";
//    }
//    var x = s.Remove(s.Length-1);
//    return x;
//    return string.Join(" ", str.Split(' ').Reverse());
//    string[] words = str.Split(' ');
//    Array.Reverse(words);
//    return string.Join(" ", words);
//}

//public static int Litres(double time)
//{
//    double drink = 0.5;
//    time = time * drink;
//    int value = (int)time;
//    return value;
//}
//public static int Number(List<int[]> peopleListInOut)
//{
//    int sum1 = 0;
//    int sum2 = 0;
//    int lastvalue = 0;

//    for (int i = 0; i<peopleListInOut.Count(); i++)
//    {
//        sum1 += peopleListInOut[i].First();
//        sum2 += peopleListInOut[i].Last();
//    }
//    lastvalue = sum1 - sum2;
//    if (lastvalue<0)
//    {
//        return 0;
//    }
//    return lastvalue;
//}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////Skladeczki i oprocentowania
//public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
//{
//    int years = 0;
//    while (principal < desiredPrincipal)
//    {
//        double oprocentowanieWSkaliRoku = ((principal * interest) - (principal * interest * tax));
//        principal += oprocentowanieWSkaliRoku;
//        years++;
//    }
//    Console.WriteLine("v YEARS WHAT YOU NEED v");
//    return years;
//}

//return (int)Math.Ceiling(Math.Log(dp / p, 1 + (i * (1 - t))));
//var years = 0;
//while (Principal < DesiredPrincipal)
//{
//    Principal += Principal * Interest * (1 - Tax);
//    years++;
//}
//return years;

///////////////////////////////////////////////////////////////2 Litery nie moga wystepowac kolo sb  
//public static bool IsIsogram(string str)
//{
//  string b= str.ToLower();
//    for (int i = 0; i < b.Length; i++)
//        for (int j =i+1; j < b.Length; j++)
//        {
//            if (b[i] == b[j])
//                return false;
//        }
//    return true;
//    var chars = str.ToLower().ToCharArray();
//    var hash = new HashSet<char>();

//    foreach (var c in chars)
//    {
//        if (hash.Contains(c))
//        {
//            return false;
//        }
//        else
//        {
//            hash.Add(c);
//        }
//    }
//    return str.ToLower().Distinct().Count() == str.Length;
//     => str.ToLower().Distinct().Count() == str.Length;
//}
//////////////////////////////////////////////////////////////////////////tablica gdzie 2 = -2
//public static int[] InvertValues(int[] input)
//{
//return input.Select(n => -n).ToArray();
//   for (int i = 0; i < input.Count(); i++) input[i] *= -1;
//return input;
//    for (int i = 0; i < input.Length; i++)
//    {
//        if (input[i]>0)
//        {
//            input[i] = -input[i];
//        }else if (input[i] < 0)
//        {
//            input[i] = input[i] * (-1);
//        }
//        else
//        {
//            input[i] = 0;
//        }
//    }
//    return input;
//}
//    public static string MSSG(string s)
//    {

//        var b = Kajman.ClearNumber(s);
//        var c = Kajman.ClearSpecialCharacter(b).ToString();
//        return new string(c.ToArray().Reverse().ToArray());
//    }
//    public static string ClearNumber(string s) => Regex.Replace(s, "[1234567890]", "", RegexOptions.IgnoreCase);
//    public static string ClearSpecialCharacter(string s) => Regex.Replace(s, "[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~]", "", RegexOptions.IgnoreCase);
//}
//   public static string Disemvowel(string str)
//   {
//       return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
//   }
//    return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
//         public static string Disemvowel(string str)
//   {
//       return Regex.Replace(str, "[euioa]", "", RegexOptions.IgnoreCase); ;
//   }
//   /// <summary>
//   /// 
//   /// </summary>
//   string strNew = "";

//   string[] strings = str.Split('a', 'u', 'e', 'i', 'o', 'A', 'U', 'E', 'I', 'O');

//           foreach (var item in strings)
//           {
//               strNew += item;
//           }

//   return strNew;


//////////////////////////////////////////////////////////////////// pierwszy string _ dodanie
//public static string PigLatin(string s)
//{
//    string str = "";
//    var v = s.Split(' ').ToArray();
//    for (int i = 0; i < v.Length; i++)
//    {
//        string rev = "";
//        var b = v[i].ToCharArray();

//        for (int j = 1; j < b.Length; j++)
//        {
//            rev += b[j];
//        }
//        str += rev + b[0] + "ay" + "*";

//    }
//  string strfinish= str.Remove(str.Length-1);
//    return strfinish;
//    return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
//    return Regex.Replace(str, "(?<=^| )(\\w)(\\w+)", m => m.Groups[2].Value + m.Groups[1].Value + "ay");,  
//    return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
//    var words = str.Split(' ');
//    var sb = new StringBuilder();
//    for (int i = 0; i < words.Length; i++)
//    {
//        sb.Append(words[i].Substring(1));
//        sb.Append(words[i][0]);
//        sb.Append("ay ");
//    }

//    return sb.ToString().TrimEnd(' ');
//}


//public static string Longest(string s1, string s2)
//{
//    string s3 = "";
//    char[] x1 = s1.ToCharArray();
//    Array.Sort(x1);
//    char[] x2 = s2.ToCharArray();
//    Array.Sort(x2);
//    if (x1.Length >=x2.Length)
//    {
//        {

//        }while (x1.Length == x2.Length) ;
//    }
//    if (x1.Length >= x2.Length)
//    {
//        for (int i = 0; i < x1.Length; i++)
//        {
//            if (x1[i] <= x2[i])
//            {
//                s3 += x1[i];
//            }
//            else
//                s3 += x2[i];
//        }
//    }
//    else
//    {
//        for (int j = 0; j < x2.Length; j++)
//            {                         
//            if (x1[j] <= x2[j])
//            {
//                s3 += x1[j];
//            }
//            else
//                s3 += x2[j];
//        }
//    }
//        return s3;

//}
//var countedWord = s.Split(' ').Average(x => x.Length);
//Convert.ToInt32(countedWord);
//Console.WriteLine(countedWord);
///////////////////////////////////////////////////////////////////////////////AVG stringow
//    public static double AvgStr(string str)
//    {
//        double d = WordCount(str);
//        double sum = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] != ' ')
//            {
//                sum++;
//            }
//        }
//        double avg = (sum / d);
//        Console.WriteLine(avg);
//        int z;
//        if (avg % 1 ==0 || avg == 3.25)
//        {
//            z = (int)avg;
//        }else
//        z = (int)++avg;
//        return z;
//    }
//    private static int WordCount(string str)
//    {
//        return Regex.Matches(str, @"[^\s]+").Count;
//    }
//}
//public static string PigIt(string str)
//{
//    var s = str.Split(' ').Select(e => e.Substring(1) + e[0] + "ay").Join(" ");
//    return s;

//}
////////////////////////////////////////////////////////////////////////////////////////Suma Pozytywy Suma negatywy
//public static int[] CountPositivesSumNegatives(int[] input)
//{
//    if (input == null || input.Length < 1)
//    {
//        return input;
//    }
//    var array = new int[2];

//    for (var i = 0; i < input.Length; i++)
//    {
//        if (input[i] <= 0)
//        {
//            array[1] += input[i];
//        }
//        else
//        {
//            array[0] ++;
//        }
//    }
//    return array;
//    public static int[] CountPositivesSumNegatives(int[] input)
//    {
//        if (input == null || !input.Any())
//        {
//            return new int[] { };
//        }

//        int countPositives = input.Count(n => n > 0);
//        int sumNegatives = input.Where(n => n < 0).Sum();

//        return new int[] { countPositives, sumNegatives };
//        return (input == null || input.Length == 0) ? new int[0] : new int[] { input.Count(o => o > 0), input.Where(o => o < 0).Sum() };
//    }
///////////////////////////////////////////////////////////////////////////////////////////////Operatorki
//public static double basicOp(char operation, double value1, double value2)
//{
//    double x = 0;
//    if (operation=='+')
//    {
//        return x = value1 + value2;
//    }
//    if (operation== '-')
//    {
//        return x = value1 - value2;
//    }
//    if (operation == '*')
//    {
//        return x = value1 * value2;
//    }
//    if (operation == '/')
//    {
//        return x = value1 / value2;
//    }
//    switch (op)
//    {
//        case '+': return val1 + val2;
//        case '-': return val1 - val2;
//        case '*': return val1 * val2;
//        case '/': return val1 / val2;
//    }
//    return 0;
//    return op == '+' ? val1 + val2
//: op == '-' ? val1 - val2
//: op == '*' ? val1 * val2
//: val1 / val2;
//}
///////////////////////////////////////////////////////////////////////////////////////////////////Date Am to normal
//public static string ChangeDate(DateTime? s)
//{
//    return s.Value.ToString("HH:mm");
//}
//}
//public static string PasswordValidator(string s)
//{
//    char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//    string special= "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
//    s.ToCharArray();
//    for (int i = 0; i < s.Length; i++)
//        for (int j = 0; j < number.Length; j++)
//            for (int k = 0; k < special.Length; k++)
//            {
//                if (s.Length >= 7 & s.Length <= 14 & !s.Contains(" ") & s.Where(x => x > 1).Contains(number[j]) & s.Where(x => x > 1).Contains(special[k]))
//                    return "Strong";
//            }
//    return "Weak";
//}

//=======================================================================================================Liczenie Smail :D :)
//public static int CountSmileys(string[] smileys)
//{
//        string[] br = { ";]", ":[", ";*", ":$", ";-D" };
//        int count = 0;
//        //for (int i = 0; i < smileys.Length; i++)
//        //{
//        //    if (smileys[i].Length>1 && (smileys[i].Contains(":~") || smileys[i].Contains(":") || smileys[i].Contains(";-") || smileys[i].Contains(" ") ));
//        //    if (smileys[i].Contains("D") || smileys[i].Contains(')'))
//        //    {
//        //        count++;
//        //    }
//        //}
//        //for (int i = 0; i < smileys.Length; i++)
//        //    for (int j = 0; j < br.Length; j++)
//        //    {
//        //    if (smileys[i]==br[j])
//        //    {
//        //        count++;
//        //    }
//        //}
//        //return count;
//        for (int i = 0; i < smileys.Length; i++)
//        {
//            if (smileys[i].Length == 2 & (smileys[i].Contains('D') || smileys[i].Contains(')')) & ((smileys[i].Contains(':') || smileys[i].Contains(';'))))
//            {
//                    count++;
//            }
//            if (smileys[i].Length == 3 & (smileys[i].Contains('D') || smileys[i].Contains(')')) & ((smileys[i].Contains(':') || smileys[i].Contains(';')) & (smileys[i].Contains('-') || smileys[i].Contains('~'))))
//            {
//                    count++;
//            }
//        }
//        return count;
//        return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
//        Regex.Matches(string.Join(" ", smileys), "([:;][-~]?)[)D]").Count;
//          private static readonly Regex SmileyRegex = new Regex(@"^[:;][-~]?[)D]$");

//    public static int CountSmileys(string[] smileys)
//    {
//        return smileys.Count(SmileyRegex.IsMatch);
//    }
//    int num = 0;
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
//    // С# AUTHORS PLEASE DDDIIIIEEEEE!!!!!!!!!!!!!!!!!!!!!!!!!!!11111111111111
//    return num;
//}
//}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////XOxO Xo
//public static bool XO(string input)
//{
//    int countx = 0;
//    int county = 0;
//    var b = input.ToLower().ToCharArray();
//    for (int i = 0; i < input.Length; i++)
//    {
//        if (input.Length == 0)
//            return false;
//        else
//            if (b[i] == 'x')
//            countx++;
//        else if (b[i] == 'o')
//            county++;
//    }
//    if (countx == county)
//        return true;
//    return false;
//    return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
//    string low = input.ToLower();
//    return low.Count(x => x == 'x') == low.Count(x => x == 'o');

/////////////////////////////////////////////////////////FindNeedle
//public static string FindNeedle(object[] haystack)
//{
//int position = 0;
//    for (int i = 0; i<haystack.Length; i++)
//    {
//        if (haystack[i] is string && haystack[i] == "needle")
//        {
//            Console.WriteLine("Hello niddle {0}", haystack[i]);
//            position += i;
//        }
//        else
//            continue;
//    }
//    return "found the needle at position "+ position;
//return "found the needle at position " + Array.IndexOf(haystack,"needle");
//return string.Format("found the needle at position {0}", haystack.ToList().IndexOf("needle"));
//}
// int result = 0;
//    int a = 0;
//    string b;
//    if (n is int)
//    {
//        a = (int)n;
//    }
//    else
//    {
//        b = (string)n;
//        result = Int32.Parse(b);
//    }
////////////////////////////////////////////////////////////////////////////////FirstChar[R] + playingBanjo
//public static string AreYouPlayingBanjo(string name)
//{
//    //return name.Take(1).Contains('R') || name.Take(1).Contains('R') ? name + " playing banjo" : " does not playing banjo";
//    //return string.Format("{0} {1} banjo", name, char.ToLower(name[0]) == 'r' ? "plays" : "does not play");
//    //=> name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
//}
//////////////////////////////ROmanCOnvert
//public static string Solution(int n)
//{
//    string roman = "";
//    string[] thousand = { "", "M", "MM", "MMM" };
//    string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
//    string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
//    string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

//    roman += thousand[(n / 1000) % 10];
//    roman += hundred[(n / 100) % 10];
//    roman += ten[(n / 10) % 10];
//    roman += one[n % 10];

//    return roman;
//        var decimalValue = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
//        var romanNumeral = new string[]{
//          "M",
//          "CM",
//          "D",
//          "CD",
//          "C",
//          "XC",
//          "L",
//          "XL",
//          "X",
//          "IX",
//          "V",
//          "IV",
//          "I"
//        };

//        var romanized = "";

//        for (var index = 0; index < decimalValue.Length; index++)
//        {
//            while (decimalValue[index] <= n)
//            {
//                romanized += romanNumeral[index];
//                n -= decimalValue[index];
//            }
//        }

//        return romanized;

//}

////I          1
////V          5
////X          10
////L          50
////C          100
////D          500
////M          1,000
///////////////////////////////////////////////////Najmniejszy string
//public static int FindShort(string s)
//{
//    if (s.Length > 0)
//    {
//        string[] arr = s.Split(' ');
//        int min = arr.Select(x => x.Length).Min();
//        return min;
//    }
//    else
//        return 0;
//}
//////////////////////////////////////////////////////Istriangle
//    public static bool IsTriangle(int a, int b, int c)
//    {
//        if ((a + b <= c) || (a + c <= b) || (b + c <= a))
//        {
//            return false;
//        } 
//        else
//        {
//            if ((a <= 0) || (b <= 0) || (c <= 0))
//            {
//                return false;
//            } 
//            else
//            {
//                return true;
//            } 
//        } 
//    }
//    a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
//}
/////////////////////////////////////////////////////////Suma == Potega*Count
//public static bool Narcissistic(int value) //145
//{
//    int Count(int n)
//    {
//        if (n == 0)
//        {
//            return 0;
//        }
//        return n.ToString().Length;
//    }
//    int m = Count(value);
//    int sum = 0;
//    int x = value;
//    while (x>0)
//    {
//        sum += (int)Math.Pow(x % 10, m);
//        x /= 10;
//    }
//    if (value == sum)
//    {
//        return true;
//    }
//    else
//        return false;
//    var str = value.ToString();
//    return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
//    var lstInt = value.ToString().Select(x => int.Parse(x.ToString())).ToList();
//    double resultTemp = 0;

//    lstInt.ForEach(x =>
//    {
//        resultTemp += Math.Pow(x, lstInt.Count);
//    });

//    return resultTemp == value;
//    string digits = value.ToString();
//    double sumOfPoweredDigits = 0;

//    foreach (char digit in digits)
//    {
//        sumOfPoweredDigits += Math.Pow(Char.GetNumericValue(digit), digits.Length);
//    }

//    return (int)sumOfPoweredDigits == Int32.Parse(digits);

//    public static bool Narcissistic(int n) => n == n.ToString().ToCharArray().Aggregate(0, (s, d) => s + (int)Math.Pow(Int32.Parse(d.ToString()), n.ToString().Length));
//}
//    For example, take 153 (3 digits):

//    1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
//and 1634 (4 digits):

//    1^4 + 6^4 + 3^4 + 4^4 = 1 + 1296 + 81 + 256 = 1634

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////PaswwordValdiation
//    public static bool PasswordValidator(string s)
//    {

//        char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//        char[] special = { '#', '@', '!', '$', '^', '&', '*', ')', '_', '+', '-', '=', '[', ' ', '\t', '"' };
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (s.Length <= 5)
//                return false;
//            else if (s.Length > 10)
//                return false;
//            else if (s.Contains(" "))
//                return false;
//        }
//        for (int i = 0; i < number.Length; i++)
//            for (int j = 0; j < s.Length; j++)
//            {
//                if (s[j] != number[i])
//                {
//                    return false;
//                }
//            }

//        return true;
//    }
//}
//public static int testString(string str) 
//{
//   int n = 0;
//   string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//   string abc = "abcdefghijklmnopqrstuvwxyz";
//    foreach (var item in str)
//    {
//        if (abc[item]== str[item])
//        {
//            n += abc.IndexOf(str) + 1;
//        }
//        else if (str.Contains(ABC))
//        {
//            n += ABC.IndexOf(str) + 1;
//        }
//    }
//    return n;
//for (int i = 0; i < str.Length; i++)
//{
//    for (int j = 0; j < abc.Length; j++)
//    {
//        if (str[i]==abc[i])
//        {
//            n += str.IndexOf(abc[i]) + 1;
//        }
//        else if (str[i] == ABC[i])
//        {
//            n += abc.IndexOf(ABC[i]) + 1;
//        }
//    }

//}



//public class Kata
//{
//    private static int Score(string s)
//      => s.Select(e => e - 96).Sum();

//    public static string High(string s)
//     => s.Split(' ').Aggregate((r, e) => Score(r) < Score(e) ? e : r);
//}

//}

///////////////////////////////////////////////////////////Wybieranie ze stringow
//  public static IEnumerable<string> FriendOrFoe(string[] names)
//  {

//      IEnumerable<string> sq = from x in names where x.Length <= 4 orderby x ascending select x;
//      retu
//      return names.Where(x=>x.Length<=4);
//      return names.Where(name => name.Length == 4);
//      return names.Where(x => x.Length == 4);
//      return (names != null)
//? names.Where(name => name != null && name.Length == 4)
//: Enumerable.Empty<string>();
//}
///////////////////////////////////////////////////////////////BezSpacji
//public static string NoSpace(string input)
//{
//    return input.Replace(" ",string.Empty);
//    return input.Replace(" ", "");
//    return input.Replace(" ", string.Empty);
//    return input != null ? input.Replace(" ", "") : null;
//}
///////////////////////////////////////////////////////////////////Suma do potęgi 2
//public static int SquareSum(int[] n)
//{
//    int num = 0;
//    for (int i = 0; i < n.Length; i++)
//    {
//        num += n[i] * n[i];
//    }
//    return num;
//    return n.Sum(t => t * t);
//    return (int)n.Sum(i => Math.Pow(i, 2));
//}
//public static string Remove_char(string s)
//{
//    /////////////////////////////////////////////////////////////////////////Usuniecie 1 i ostatniego Stringu
//    s.Split(' ');
//    var b = s.ToCharArray();
//    string st = "";
//    for (int i = 0; i < b.Length; i++)
//    {
//        if (i == 0)
//        {
//            continue;
//        }else if(b.Length-1 == i)
//        {
//            break;
//        }
//        else
//            {
//            st += b[i];
//            }
//    }
//    return st;

//    return s.Substring(1, (s.Length - 2));
//    return s.Length >= 2 ? s.Substring(1, s.Length - 2) : "ok";
//    str = str.Remove(0, 1);
//    str = str.Remove((str.Length - 1), 1);
//    return count <= 0 ? string.Empty : s.Substring(1, count);
//}
//wyliczanka//////////////////////////////////////////////////////////////////////////////////////////Wyliczanka 
//  public static string HowMuchILoveYou(int nb_petals)
//  {
//      string[] nb = new string[] {"I love you","a little","a lot","passionately","madly","not at all"};
//      return nb[(nb_petals - 1) % nb.Length];
//      return new string[] { "I love you", "a little", "a lot", "passionately", "madly", "not at all" }[(nb_petals - 1) % 6];
//      static readonly string[] LoveЁптЭ =
// {
//       "I love you",
//       "a little",
//       "a lot",
//       "passionately",
//       "madly",
//       "not at all"
//  };

//      public static string HowMuchILoveYou(int nb_petals)
//      {
//          var count = 0;
//          for (var i = 0; i < nb_petals; i++)
//          {
//              count++;
//              if (count > 6)
//                  count = 1;
//          }

//          return LoveЁптЭ[count - 1];
//          switch (nb_petals % 6)
//          {
//              case 1: return "I love you";
//              case 2: return "a little";
//              case 3: return "a lot";
//              case 4: return "passionately";
//              case 5: return "madly";
//              case 0: return "not at all";
//              default: return "";
//          }
//  }
//}
//public static long FindNextSquare(long num)
//{
//    double s = Math.Sqrt(num);
//    s++;
//    long next = (long)(s*s);
//    if (num < 0 || Math.Sqrt(num) % 1 == 0)
//        return next;    
//    else
//        return -1;
//    return Sqrt(num) % 1 == 0 ? (long)Pow(Sqrt(num) + 1, 2) : -1;
//    ouble root = Math.Sqrt(num);

//    if (root % 1 != 0)
//        return -1;

//    return (long)Math.Pow(root + 1, 2);
//    double a = Math.Sqrt(num);
//    return (a == (int)a) ? (long)Math.Pow(a + 1, 2) : -1;
//    double root = Math.Sqrt(num);
//    long longRoot = (long)root;
//    if (root - longRoot > double.Epsilon)
//        return -1;
//    longRoot++;
//    return longRoot * longRoot;
//    long r = (long)Math.Sqrt(sq);
//    if (r * r != sq)
//        return -1;
//    return ((r + 1) * (r + 1));
//    {
//        return false;
//    }
//    return true;
//    return Math.Sqrt(n) % 1 == 0;
//    return Math.Sqrt(n) % 1 == 0;
//    public static bool IsSquare(int n)
//=> (Math.Sqrt(n) % 1 == 0);
//    return n < 0 ? false : Math.Sqrt(n) == Math.Round(Math.Sqrt(n));

//public static int findSum(int n)
//{
//    ///////////////////////////////////////////////////////////Suma Liczb 5=4321
//    int[] tab = new int [n];
//    int count = 0;
//    for (int i = 0; i < n; i++)
//    {
//        tab[i] = i+1;
//    }
//    for (int i = 0; i < tab.Length; i++)
//    {
//        if (tab[i]%3 == 0 || tab[i]%5 ==0)
//        {
//            count += tab[i];
//        }
//    }
//    return count;
//    Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
//    public static int findSum(int n) => Enumerable.Range(1, n).Where(x => x % 5 == 0 || x % 3 == 0).Sum();
//    return Enumerable.Range(1, n).Select(x => (x % 3 == 0 || x % 5 == 0) ? x : 0).Sum();
//}
///////////////////////////////////////////////////////////////////////////Ilosc Slowek daje efekt
// public static string Well(string[] x)
// {
//     int count = 0;
//     for (int i = 0; i < x.Length; i++)
//     {
//         if (x[i] == "good")
//         {
//             count++;
//         }
//     }
//     if (count > 2)
//     {
//         return "I smell a series!";
//     } else if(count > 0)
//     {
//         return "Publish!";
//     }
//     else
//     {
//         return "Fail!";
//     }
//     int count = x.Count(v => v == "good");
//     return (count > 2) ? "I smell a series!" : (count >= 1) ? "Publish!" : "Fail!";
//     var good = x.Count(y => y == "good");
//     return good == 0 ? "Fail!" : good > 2 ? "I smell a series!" : "Publish!";
//     switch (x.Count(e => e == "good"))
//     {
//         case 1:
//         case 2:
//             return "Publish!";
//         case int n when n > 2:
//             return "I smell a series!";
//         default:
//             return "Fail!";
//             public static string Well(string[] x)
//=> new string[] { "Fail!", "Publish!", "Publish!", "I smell a series!" }[Math.Min(3, x.Count(e => e == "good"))];
//             int count = x.Count(s => s == "good");

//             return (count > 2) ? "I smell a series!" : (count >= 1) ? "Publish!" : "Fail!";


//     }
//////////////////////////////////////////////////////////////////////////////objektowa Suma
//public static int SumMix(object[] x)
//{
//    int suma = 0;
//    for (int i = 0; i < x.Length; i++)
//    {
//        suma += (Convert.ToInt32(x[i]));
//    }
//    return suma;
//    public static int SumMix(object[] x) => x.Sum(ToInt32);
//    public static int SumMix(object[] x) => x.Where(w => w is IConvertible).Sum(Convert.ToInt32);
//    return x.Select(n => Convert.ToInt32(n)).Sum();
//}
//public static int Add(params int[] args){
//    int suma = 0;
//    for (int i = 0; i < args.Length; i++)
//    {
//        suma = suma + args[i];
//    }
//    return suma;
//}
//===================================================================================StringiXtimes
//public static string repeatStr(int n, string s)
//{
//    string sn = "";
//    for (int i = 0; i < n; i++)
//    {
//        sn += s;
//    }
//    return sn;
//    return String.Concat(Enumerable.Repeat(s, n));
//    return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
//    StringBuilder builder = new StringBuilder();
//    for (int i = 0; i < n; i++)
//    {
//        builder.Append(s);
//    }
//    return builder.ToString();
//    return string.Concat(Enumerable.Repeat(s, n));
//    return string.Join("", Enumerable.Repeat(s, n));
//}
//Sortowanie 1 liczby==========================================================================================================
//public static int[] SortArray(int[] array)
//{
//Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));

//return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();

//List<int> odd = new List<int>();

//foreach (var number in array)
//{
//    if (number % 2 != 0)
//        odd.Add(number);
//}
//int[] oddAr = odd.ToArray();
//Array.Sort(oddAr);


//for (int i = 0, j = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0)
//    {
//        array[i] = oddAr[j];
//        j++;
//    }
//}
//return array;

//var list = new List<int>(array);
//var oddNumbers = list.Where(x => x % 2 == 1).OrderBy(x => x).ToList();
//var oddIndex = 0;
//return list.Select(x => (x % 2 == 1) ? oddNumbers[oddIndex++] : x).ToArray();

//int[] sortedOddNumbers = array.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();
//int i = 0;
//foreach (int oddNumber in sortedOddNumbers)
//{
//    while (array[i] % 2 == 0)
//    {
//        i++;
//    }
//    array[i] = oddNumber;
//    i++;
//}
//return array;

//    if (array.Length == 0) return array;
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//        if (array[i] % 2 == 0) continue;
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[j] % 2 == 0) continue;
//            if (array[j] < array[i])
//            {
//                int aux = array[i];
//                array[i] = array[j];
//                array[j] = aux;
//            }
//        }
//    }
//    return array;
//}        //for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 != 0)
//    {
//        var aux = 0;
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[i] > array[j] && array[j] % 2 != 0)
//            {
//                aux = array[i];
//                array[i] = array[j];
//                array[j] = aux;
//            }
//        }
//    }
//}
//return array;

//    int[] b;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i]%2 != 0)
//        {
//            b = array[i];
//        }
//    }
//}
/// <summary>
/// //////////////////////////////////////////////////////////////////////SPRAWDZANIE PINU DIGT 4-6
/// </summary>
//public static bool ValidatePin(string pin)
//{
//    var a = Regex.IsMatch(pin, "^[0-9][0-9][0-9][0-9]");
//    var b = Regex.IsMatch(pin, "^[0-9][0-9][0-9][0-9][0-9][0-9]");
//    if (pin.Length == 4)
//    {
//        return a;
//    }
//    else if (pin.Length == 6)
//    {
//        return b;
//    }
//    else
//        return false;
//}
//         return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
//         return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
//        public static bool ValidatePin(string pin) => new Regex("^((\\d{4})|(\\d{6}))$").IsMatch(pin);
//    public static bool ValidatePin(string pin) => new Regex("^((\\d{4})|(\\d{6}))$").IsMatch(pin);
//      if(pin.Length == 4  || pin.Length == 6) {
//      for(var chr=0;chr<pin.Length;chr++){
//        if(!Char.IsDigit(pin, chr)){
//          return false;
//        }
//      }
//      return true;
//    }
//    else return false;
//  }
//}
//   int val;
//    return (pin.Length != 4 && pin.Length != 6) ? false : int.TryParse(pin, out val);
//   string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" }; 
//   for (int i = 0; i<vowels.Length; i++)
//   {
//     str = str.Replace(vowels[i],"");  
//   }
//       return str;
//   }
//   return Regex.Replace(str, @"(?i)[aeiou]", "");
//////////////////////////////////////////////////////////////////////Usuwanie znaków 
//   public static string Disemvowel(string str) => Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
//   public static string Disemvowel(string str)
//   {
//       return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
//   }
//    return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
//         public static string Disemvowel(string str)
//   {
//       return Regex.Replace(str, "[euioa]", "", RegexOptions.IgnoreCase); ;
//   }
//   /// <summary>
//   /// 
//   /// </summary>
//   string strNew = "";

//   string[] strings = str.Split('a', 'u', 'e', 'i', 'o', 'A', 'U', 'E', 'I', 'O');

//           foreach (var item in strings)
//           {
//               strNew += item;
//           }

//   return strNew;

//return str.Replace('a', ' ').Replace('e', ' ').Replace('u', ' ').Replace('y', ' ').Replace('i', ' ').Replace('o', ' ');

//var s = str.ToCharArray();
//char[] b = new char[] { 'a', 'u', 'i', 'o', 'e', 'y' };
//string st = "";
//for (int i = 0; i < b.Length; i++)
//{ 
//        if (str.Contains(b[i]))
//        {
//        }
//        else
//        {
//            st += str[i];
//        }
//    }
//return st;


//=================================================================================================Zadanko DNA zmiana znakow
//public static string MakeComplement(string dna)
//{
//    var b = dna.ToCharArray();
//    string s = "";
//    if (dna == null)
//    {
//        return "";
//    }
//    else
//    {
//        for (int i = 0; i < b.Length; i++)
//        {
//            switch (b[i])
//            {
//                case 'A':
//                    b[i] = 'T';
//                    s += b[i];
//                    break;
//                case 'T':
//                    b[i] = 'A';
//                   s += b[i];
//                    break;
//                case 'G':
//                    b[i] = 'C';
//                    s += b[i];
//                    break;
//                case 'C':
//                    b[i] = 'G';
//                  s += b[i];
//                    break;
//                default:
//               s += b[i];
//                    break;
//            }
//        }
//        return s;
//    public static string MakeComplement(string dna)
//    {
//        return dna.Replace('T', '?').Replace('A', 'T').Replace('?', 'A').Replace('G', '?').Replace('C', 'G').Replace('?', 'C');
//    }
//}

//                private static Dictionary<char, char> map =
//        new Dictionary<char, char>
//        {
//            {'T', 'A'},
//            {'A', 'T'},
//            {'C', 'G'},
//            {'G', 'C'}
//        };

//public static string MakeComplement(string dna)
//{
//    var mychars = dna.ToCharArray();

//    var outChars = new String(mychars.Select(x => map[x]).ToArray());

//    return outChars;
//}
//}
//        public static string MakeComplement(string dna)
//        {
//            return string.Concat(dna.Select(GetComplement));
//        }

//        public static char GetComplement(char symbol)
//        {
//            switch (symbol)
//            {
//                case 'A':
//                    return 'T';
//                case 'T':
//                    return 'A';
//                case 'C':
//                    return 'G';
//                case 'G':
//                    return 'C';
//                default:
//                    throw new ArgumentException();
//            }
//        }
//================================================================Sprawdzanie czy jest null  i czy zawiera niedozwolony znak
//  public static bool Alphanumeric(string str) 
//  {

//      //char[] s = { '#', '@', '!', '$', '^', '&', '*', ')', '_', '+', '-', '=', '[' , ' ','\t','"'};
//      //var k = str.ToCharArray();

//      //if (str=="")
//      //{
//      //    return false;
//      //}else
//      //for (int i = 0; i < k.Length; i++)
//      //    for (int j = 0; j < s.Length; j++)
//      //        if (k[i] == s[j])
//      //            return false;
//      //return true;
////public static bool Alphanumeric(string str) =>
////new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
////      public static bool Alphanumeric(string str)
////      {
////          return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
////      }
////      public static bool Alphanumeric(string s) => new Regex("^[a-zA-Z0-9]+$").IsMatch(s);
////      public static bool Alphanumeric(string str) => IsMatch(str, @"^[a-zA-Z\d]+$");
////      return str.All(char.IsLetterOrDigit) && !string.IsNullOrEmpty(str);
////        => Regex.Match(str, @"^[\da-zA-Z]+$").Success;
//  }













//=========================================================czy jeden string jest w drugim niedokonczone
//public static string[] inArray(string[] array1, string[] array2)
//{
//    string[] r= { };
//    string rs= "";
//    for (int i = 0; i < array1.Length; i++)
//        for (int j = 0; j < array2.Length; j++)
//            if (array1[i].Contains(array2[j]))
//            {
//                rs += array1[i];
//                Console.WriteLine(rs) ;
//            }

//    return r;
// return set12;



//=======================================================================OBJekt a zawiera B
//  public static bool Check(object[] a, object x)
//  {
//      //if (a.Contains(x))
//      //{
//      //    return true;
//      //}
//      //return false;
//      return a.Contains(x) ? true : false;

// ========================================================================== aVG ARRAY
//public static double FindAverage(double[] array)
//{
//    double avg=0;
//    double suma=0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        suma += array[i];
//    }
//    for (int i = 0; i < array.Length; i++)
//    {
//        avg = suma / array.Length;
//    }
//    return avg;
//    //return array.Length == 0 ? 0 : array.Average();
//    //   if ( array == null )
//    //throw new ArgumentNullException(nameof(array), "Array can not be null");

//    //return array.Any() ? array.Average() : 0;
//    //  if (array.Length == 0) return 0;
//    //  return array.Average();
//   // return array.Length > 0 ? array.Average() : 0;









//==============================================================================petlaObject===================
//kata cannot complile this solution but this program work 100%
//https://www.codewars.com/kata/alan-partridge-ii-apple-turnover/train/csharp
//public static string Apple(object n)
//{
//    int result = 0;
//    int a = 0;
//    string b;
//    if (n is int)
//    {
//        a = (int)n;
//    }
//    else
//    {
//        b = (string)n;
//        result = Int32.Parse(b);
//    }
//    if (n is int)
//    {
//        if (a * a < 1000)
//        {
//            return "Help yourself to a honeycomb Yorkie for the glovebox.";
//        }else  {
//            return "It's hotter than the sun!!";
//        }
//    }
//    else
//    {
//        if (result * result > 1000)
//        {
//            return "It's hotter than the sun!!";
//        }
//        else
//        {
//            return "Help yourself to a honeycomb Yorkie for the glovebox.";
//        }
//    }



//==========================================================================================Number telefoniren   
//public static string CreatePhoneNumber(int[] numbers)
//{
//    //string s = string.Join("", numbers);
//    //return string.Format("({0}) {1}-{2}",
//    //    s.Substring(0, 3),
//    //    s.Substring(3, 3),
//    //    s.Substring(6));
//    //  return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
//    //  return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
//    //  public static string CreatePhoneNumber(int[] numbers) =>
//    //new Regex("(...)(...)(....)").Replace(String.Concat(numbers), "($1) $2-$3");
//    // return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
//    //  return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
//    //return String.Format("{0:(000) 000-0000}", ulong.Parse(String.Join("", numbers)));
//    //return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
//}
//===================================================================================SQUARE NUMBER ! +++ liczby pierwiast
//public static bool IsSquare(int n)
//{
//    if (n < 0 || Math.Sqrt(n) % 1 !=0 )
//    {
//        return false;
//    }
//    return true;
//    return Math.Sqrt(n) % 1 == 0;
//    return Math.Sqrt(n) % 1 == 0;
//    public static bool IsSquare(int n)
//=> (Math.Sqrt(n) % 1 == 0);
//    return n < 0 ? false : Math.Sqrt(n) == Math.Round(Math.Sqrt(n));

//==========================================================Stringi revers wyrazy wieksze niz 5=====================
//public static string wt(string sentence)
//{
//    return new string(sentence.ToArray().Reverse().ToArray());
//}
//public static string SpinWords(string sentence)
//{
//    //  new string(str.ToArray().Reverse().ToArray());

//    string s = "";
//    var sr = sentence.Split(' ');
//    for (int i = 0; i < sr.Length; i++)
//    {
//        if (sr[i].Length>=5)
//        {
//            sr[i] = wt(sr[i]);
//        }
//    }
//    String joined = String.Join(" ", sr);
//    return joined;
//  return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string (str.Reverse().ToArray()) : str));

//for (int i = ch.Length-1; i>0 ; i--)
//{
//    if (true)
//    {

//    }
//}

//   var ch= str.ToCharArray();
//    string s="";
//    for (int i = ch.Length - 1 ; i >=0; i--)
//    {
//        s += str[i];
//    }
//    return s;
//    public static string SpinWords(string sentence)
//    {
//        var words = sentence.Split(' ').Where(w => w.Length > 4);
//        foreach (var w in words) sentence = sentence.Replace(w, Reverse(w));
//        return sentence;
//    }

//    public static string Reverse(string s)
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}
//string[] words = sentence.Split(' ');
//        for (var i = 0; i<words.Count(); i++)
//        {
//            if (words[i].Length >= 5)
//            {
//                words[i] = new string (words[i].Reverse().ToArray());
//            }
//        }

//        return string.Join(" ", words);

//}
//=======================================================================WIeki===================================================
//public static int СenturyFromYear(int year)
//{

//    int Tysiaclecia=  year / 100;
//    if (year % 100 > 0)
//    {
//        Tysiaclecia += 1;
//    }
//    return Tysiaclecia;
//    //  public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;
//    // return (year - 1) / 100 + 1;
//    //public static int СenturyFromYear(int year) => year % 100 == 0 ? year / 100 : year / 100 + 1;
//}

//===========================================================================================Zliczanie True z BOOLI=============================
// public static int CountSheeps(bool[] sheeps)
// {
//public static int CountSheeps(bool[] sheeps) => sheeps.Where(s => s).Count();


//int count = 0;
//foreach (bool sheep in sheeps)
//{
//    if (sheep) count++;
//}
//return count;
// return sheeps.Count(c => c);
// int numTrue = 0;
//TODO
//foreach (bool isTrue in sheeps)
//{
//    if (isTrue == true)
//    {
//        numTrue++;
//    }
//}
//return numTrue;
//}
//
//========================================================= EZ PENTA
//public static string MouthSize(string animal)
//{
//      return  animal != "aligator" ? "wide" : "small";
//      //https://www.codewars.com/kata/the-wide-mouthed-frog/train/csharp

//      //if (animal == "aligator")
//      //{
//      //    return "small";
//      //}
//      //else
//      //{
//      //    return "wide";
//      //}
//  }


//=============================================================ZAMIANA LITER==========================
//public static string Solution(string str)
//{
//   var ch= str.ToCharArray();
//    string s="";
//    for (int i = ch.Length - 1 ; i >=0; i--)
//    {
//        s += str[i];
//    }
//    return s;
//public static string Solution(string str)
//{
//    return new string(str.ToArray().Reverse().ToArray());
//}
//public static string Solution(string str) => string.Concat(str.Reverse());
//return string.Concat(str.Reverse());
// return new String(str.Reverse().ToArray());
//==================================================================== BANK HASHTAGI ========================================== 
//    public static string Maskify(string cc)
//    {
//        var ch = cc.ToCharArray();
//        string s = "";
//        for (int i = 0; i < ch.Length; i++)
//        {
//            if (i < ch.Length - 4)
//            {
//                s += "#";
//            }
//            else
//            {
//                s += ch[i];
//            }
//        }
//        return s;



//int len = cc.Length;
//if (len <=4)
//  return cc;

//return cc.Substring(len-4).PadLeft(len, '#');

//for (int i = 0; i<cc.Length - 4; i++)
//{
//    cs[i] = '#';
//}

//return string.Concat(cs);
//  return cc.Substring(cc.Length< 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');
// return cc.Length > 4 ? cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#') : cc;
//StringBuilder sb = new StringBuilder(cc);

//for (int i = cc.Length - 5; i >= 0; i--)
//  sb[i] = '#';

//return sb.ToString();

//    }
//}


//=================================================================Dicitionary ilosc literek i wystapienia ===============================================

//public static Dictionary<char, int> Count(string str)
//{
//    return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
//Dictionary<char, int> d = new Dictionary<char, int>();
//string str = "";
//d.Add('a', 2);
//d.Add('b', 2);
//foreach (KeyValuePair<char, int> kvp in d)
//{
//    for (int i = 0; i < kvp.Value; i++)
//    {
//        str+= kvp.Key.ToString();
//    }
//    Console.WriteLine(str);
//}
//}
//Dictionary<char, int> d = new Dictionary<char, int>();
//d.Add('a', 2);
//foreach (KeyValuePair<char, int> kvp in d)
//{
//    Console.WriteLine("key{0} , value ={1}", kvp.Key, kvp.Value);
//}
//  Console.WriteLine(Kata.Count("halko"));
//Dictionary<char, int>.ValueCollection valcoll = d.Values;
// foreach (var item in valcoll)
// {
//     Console.WriteLine("value = {0}", item);
// }



//public static string High(string s)
//{
//    return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
//}
//=============================================================================================== RPG ====================================================================
//public class Fighter
//{
//    public string Name;
//    public int Health, DamagePerAttack;
//    public Fighter(string name, int health, int damageperattack)
//    {
//        this.Name = name;
//        this.Health = health;
//        this.DamagePerAttack = damageperattack;
//    }
//    public int Attack()
//    {
//        return DamagePerAttack;
//    }
//    public void ActualHel(int damage)
//    {
//        this.Health = this.Health - damage;
//    }
//}



//public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
//{
//    string s;
//    int f1h = fighter1.Health;
//    int f1d = fighter1.DamagePerAttack;
//    int f2h= fighter2.Health ;
//    int f2d = fighter2.DamagePerAttack;
//    string f1 = fighter1.Name;
//    string f2 = fighter2.Name;
//    if (firstAttacker == fighter1.Name)
//    {
//        while (fighter1.Health > 0 & fighter2.Health > 0)
//        {
//            fighter1.ActualHel(fighter2.Attack());
//            fighter2.ActualHel(fighter1.Attack());
//        }
//    }else
//    { 
//        while (fighter1.Health > 0 & fighter2.Health > 0)
//        {
//            fighter2.ActualHel(fighter1.Attack());
//            fighter1.ActualHel(fighter2.Attack());
//        }
//    }
//    if (fighter1.Health > 0)
//    {
//        Console.WriteLine(fighter1.Name);
//        return fighter1.Name.ToString();
//    }
//    else if (fighter2.Health > 0)
//    {
//        Console.WriteLine(fighter2.Name);
//        return fighter2.Name.ToString();
//    }
//    else
//        return f1;
//}
//=====================================================================Najdluzszy wyraz sumujacy litery===================
//public static string High(string s)
//{
//    return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
//}
//    string[] words = s.Split(' ');
//    string highestWord = "";
//    int highestNumber = 0;

//    foreach (string word in words)
//    {
//        int number = WordsToMarks(word);
//        if (highestNumber < number)
//        {
//            highestWord = word;
//            highestNumber = number;
//        }
//    }
//    return highestWord;
//}

//public static int WordsToMarks(string str)
//{
//    int n = 0;
//    string abc = "abcdefghijklmnopqrstuvwxyz";
//    foreach (char x in str)
//    {
//        n += abc.IndexOf(x) + 1;
//    }
//    return n;
//}
//public class Kata
//{
//    private static int Score(string s)
//      => s.Select(e => e - 96).Sum();

//    public static string High(string s)
//     => s.Split(' ').Aggregate((r, e) => Score(r) < Score(e) ? e : r);
//}
////int Duplicate = diper.Length + 1;
//        var counts = diper
//.GroupBy(w => w)
//.Select(g => new { Word = g.Key, Count = g.Count() })
//.ToList();

//        foreach (var p in counts)
//        {
//            Console.WriteLine("Word '{0}' found {1} times", p.Word, p.Count);
//        }
//for (int i = 0; i < diper.Length; i++)
//{
//    int count = 1;
//    for (int j = 0; j < diper.Length; j++)
//    {
//        if (i!= j)
//        {
//            if (string.Compare(diper [i],diper [j]) ==0)
//            {
//                count++;
//                Duplicate = j;
//            }                       
//        }

//    }
//    if (i !=Duplicate)
//    {
//        Console.WriteLine("{0}  ,{1} ", diper[i], count);
//    }
//    Console.WriteLine("{0}  ,{1} ",diper[i],count);
//}
//foreach (int item in Enum.GetValues(typeof(Literki)))
//    Console.WriteLine(item);

//for (int i = 0; i < diper.Length; i++)
//{
//    suma+=diper[i]
//}
//}







//class Digitizer
//  {//Example:
//348597 => [7,9,5,8,4,3]
//public static long[] Digitize(long n)
//{
//    long kolejna_cyfra;
//    long[] tab;
//    while (n>0)
//    {
//        kolejna_cyfra = n % 10;
//        n /= 10;
//        tab = n;
//    }
//    //while (tab[n] > 0) // drobna zmiana jest wymagana gdy liczba jest ujemna
//    //{
//    //    kolejna_cyfra = n % 10;
//    //    n /= 10;
//    //}
//    return ;
//   }



//function digitize(n)
//{
//    debugger;
//    var array = [];
//    while (n > 0)
//    {
//        var digit = n % 10
//      nextSeq = Math.floor(n / 10);
//        array.push(digit);
//        n = nextSeq;
//    }
//    return array;
//}
//=============================================================================Tablica rangge x * powtorzenie
//public class Kata
//{//countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
// //   countBy(2,5)  should return {2,4,6,8,10}
//    public static int[] CountBy(int x, int n)
//    {

//        int[] tab1 = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            tab1[i] = x * (i + 1);
//        }
//        return tab1;



//public static class Kata
//{
//    public static int[] CountBy(int x, int n)
//    {
//        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
//    }
//}
//public static class Kata

//    {

//        public static int[] CountBy(int x, int n)

//        {

//            int[] z = new int[n];

//            for (int i = 0; i < n; i++)

//            {

//                z[i] = x * (i + 1);

//            }

//            return z;

//        }

//    }


//===================================================================================Duze Liter======================================


//public static string MakeUpperCase(string str)
//{
//    str.
//             return "str to upperCase";
//}


//====================================================================================Najmniejsza literka

//public static int FindShort(string value)
//{
//    if (null == value)
//        return 0; // or throw new ArgumentNullException(nameof(value));

//    return Regex
//      .Matches(value, @"[\p{L}']+") // word is one or more letter or apostroph
//      .Cast<Match>()
//      .Min(match => match.Value.Length);


//Regex initials = new Regex(@"(\b[a-zA-Z])[a-zA-Z]* ?");
//string init = initials.Replace(s, "$1");
//return init;
//  string lancuch = " Elko elko hejasddsako hejko ";
//  string[] words = lancuch.Split(new[] { " " }, StringSplitOptions.None);
//String[] arr = s.Split(' ');
//arr.ToList();
//int min = arr.Select(x => x.Length).Min();
//arr.OrderByDescending(x => x.Length);
//return min;
//var charArray = s.Split(' ');
//string[] word;
//for (int i = 0; i < charArray.Length; i++)
//{
//    word.OrderBy(num => num.Length).ToArray();
//}

//string[] words = s.Split(new[] {" "}, StringSplitOptions.None);
//int min = words.Min(a => a.Length);
//return min;


//string word = "";
//int ctr = 0;
//foreach (var k in words)
//{
//    if (k.Length > ctr)
//    {
//        word = k;
//        ctr = k.Length;
//    }
//    return k;
//}
//int k = int.MaxValue;
//string[] words = s.Split(' ') ;
//for (int i = 0; i < words[i].Length; i++)
//{
//    k = Math.Min(k, words[i].Get) ;
//}
//return k;


//string[] arr = {"a", "abc", "dbc", "dlugie", "dddd"};
//    int minLen = arr.Min(a => a.Length);
//    int maxLen = arr.Max(a => a.Length);
//    string minStr = arr.First(a => a.Length == minLen);
//    string maxStr = arr.First(a => a.Length == maxLen);
//    Console.WriteLine(minStr);
//Console.WriteLine(maxStr);
//================================================================================================ Usuwa najmneijsza litere
//public class Remover
//{
//    public static List<int> RemoveSmallest(List<int> numbers)
//    {
//        List<int> aggre;
//        int minNumber = numbers.Min();
//        aggre = new List<int>(numbers);

//        foreach (var item in numbers)
//        {

//            if (item != minNumber)
//            {
//                aggre.Remove(minNumber);
//                Console.WriteLine(item);
//            }
//        }
//        return aggre;
//for (int i = 0; i < length; i++)
//{
//for (var i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] < smallest)
//    {
//        smallest = numbers[i];
//    }
//}
//for (var j = 0; j < numbers.Count; j++)
//{
//    if (j != numbers.IndexOf(smallest))
//    {
//        outputArr.Take(numbers[j]);
//    }
//}
// console.log(numbers.indexOf(smallest))



//public class Kata
//{
//    public static int[] Maps(int[] x)
//    {
//        for (int i = 0; i < x.Length; i++)
//        {
//            x[i] *= 2;
//        }

//        //  return x.Select(e => e * 2).ToArray();
//        //return x.Select(f => f * 2).ToArray();
//        return x;
//    }


//============================================================================== SUmująca=====================================

//public static class Kata
//{
//    public static int summation(int num)
//    {

//        var total = 0;
//        for (int i = 1; i <= num; i++)
//        {
//            total += i;
//            Console.WriteLine(total);
//        }
//        return total;

//    }
//}

public static class Kajmans
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < str.Length; i++)
            for (int j = 0; j < vowel.Length; j++)
            {
                if (str[i] == vowel[j])
                {
                    vowelCount++;
                }
            }
        return vowelCount;
    }
    public static string ToAlternatingCase(this string s)
    {
        var low = s.ToLower().ToCharArray();
        var Up = s.ToUpper().ToCharArray();
        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            int j = 0;
            j++;
            int k = 0;
            k++;
            if (s[i] == low[i])
            {
                str += s[i].ToString().ToUpper();
            }
            else if (s[i] == Up[i])
            {
                str += s[i].ToString().ToLower();
            }
            else
                str += s[i];
        }
        return str;
        // return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        // return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
    }
    public static string greet()
    {
        return "hello world!";
    }

    public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property)
    {
        return ApplyOrder<T>(source, property, "OrderBy");
    }
    public static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string property)
    {
        return ApplyOrder<T>(source, property, "OrderByDescending");
    }
    public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, string property)
    {
        return ApplyOrder<T>(source, property, "ThenBy");
    }
    public static IOrderedQueryable<T> ThenByDescending<T>(this IOrderedQueryable<T> source, string property)
    {
        return ApplyOrder<T>(source, property, "ThenByDescending");
    }
    static IOrderedQueryable<T> ApplyOrder<T>(IQueryable<T> source, string property, string methodName)
    {
        string[] props = property.Split('.');
        Type type = typeof(T);
        ParameterExpression arg = Expression.Parameter(type, "x");
        Expression expr = arg;
        foreach (string prop in props)
        {
            // use reflection (not ComponentModel) to mirror LINQ
            PropertyInfo pi = type.GetProperty(prop);
            expr = Expression.Property(expr, pi);
            type = pi.PropertyType;
        }
        Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
        LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

        object result = typeof(Queryable).GetMethods().Single(
                method => method.Name == methodName
                        && method.IsGenericMethodDefinition
                        && method.GetGenericArguments().Length == 2
                        && method.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), type)
                .Invoke(null, new object[] { source, lambda });
        return (IOrderedQueryable<T>)result;
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
        //   return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
        //var words = str.Split(' ');
        //var finalString = string.Empty;

        //foreach (var word in words)
        //{
        //    finalString += word.Length > 0 ? (word.Substring(0, 1).ToUpper() + word.Substring(1)) : string.Empty;
        //}

        //return finalString;
    }
}
