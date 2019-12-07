using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Table_Del
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CreatePhoneNumber(new int[] {0,1,2,3,4,6,7,8,9}));
            //Console.WriteLine(Kata.IsSquare(25));
            // Console.WriteLine(Kata.СenturyFromYear(2000));
            //Console.WriteLine(Kata.CountSheeps(new bool[] { true, false, true, false, true }));  
            // Console.WriteLine(Kata.MouthSize("ant bear"));
           // Console.WriteLine(Kata.SpinWords("karolas sw eda koskaasas"));
            //      Kata.declareWinner(new Fighter("Lew", 22, 6), new Fighter("Harry", 10, 4), "Lew");
            //Remover.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 } );
            //  Console.WriteLine(Kata.Maps(new[] { 1, 2, 3 })); 
            //Kata.summation(10);
            //  Console.WriteLine(Kata.FindShort("Karol to kozak"));
            //  Console.WriteLine(Kata.Opposite(2));   
            //  Console.WriteLine(Kata.MakeUpperCase(" saddsa dasad"));   
            // Console.WriteLine(Digitizer.Digitize(34));
            //Console.WriteLine(Kata.Solution("karol"));
            //Console.WriteLine(Kata.High("TO jest super String wwxq"));
            Console.ReadKey();

        }
    }
}
public class Kata
{


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
}
    //================================================================================Stringi revers wyrazy wieksze niz 5=====================
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
public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name , int health , int damageperattack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damageperattack;
        }
        public int Attack()
        {
            return DamagePerAttack;
        }
        public void ActualHel(int damage)
        {
            this.Health = this.Health - damage;
        }
    }
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
//============================================================================================Najdluzszy wyraz sumujacy litery===================
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
