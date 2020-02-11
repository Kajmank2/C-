using System;
using System.Collections.Generic;
using System.Text;

namespace LongestArray.Platinium
{
   public class Platinium
    {
        public static long NextBiggerNumber(long n)
        {
            var arr = n.ToString();
            var y = arr.ToCharArray();
            var x = arr.Length;

            return Platinium.findNext(y, x);
        }
        public static void swap(char[] ar, int i, int j)
        {
            char temp = ar[i];
            ar[i] = ar[j];
            ar[j] = temp;
        }
        public static long findNext(char[] ar, int n)
        {
            int i;
            string s = "";
            for (i = n - 1; i > 0; i--)
            {
                if (ar[i] > ar[i - 1])
                {
                    break;
                }
            }

            if (i == 0)
            {
                return -1;
            }
            else
            {
                int x = ar[i - 1], min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[j] > x && ar[j] < ar[min])
                    {
                        min = j;
                    }
                }

                swap(ar, i - 1, min);

                Array.Sort(ar, i, n - i);
                for (i = 0; i < n; i++)
                    s += ar[i];
                var finish = long.Parse(s);
                return finish;
            }
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
            //Other solution
            //if (n < 10) return -1;
            //string s = n + "";
            //for (int i = s.Length - 2; i >= 0; i--)
            //{
            //    if (s.Substring(i) != string.Concat(s.Substring(i).OrderByDescending(x => x)))
            //    {
            //        var t = string.Concat(s.Substring(i).OrderBy(x => x));
            //        var c = t.First(x => x > s[i]);
            //        return long.Parse(s.Substring(0, i) + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
            //    }
            //}
            //return -1;
            //public static long NextBiggerNumber(long n)
            //{
            //    String str = GetNumbers(n);
            //    for (long i = n + 1; i <= long.Parse(str); i++)
            //    {
            //        if (GetNumbers(n) == GetNumbers(i))
            //        {
            //            return i;
            //        }
            //    }
            //    return -1;
            //}
            //public static string GetNumbers(long number)
            //{
            //    return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
            //}
        }
    }
}

