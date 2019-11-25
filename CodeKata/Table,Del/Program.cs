using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Del
{
    class Program
    {
        static void Main(string[] args)
        {
            Remover.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 } );
            //  Console.WriteLine(Kata.Maps(new[] { 1, 2, 3 })); 
            //Kata.summation(10);

            Console.ReadKey();

        }
    }
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> aggre;
            int minNumber = numbers.Min();
            aggre = new List<int>(numbers);

            foreach (var item in numbers)
            {

                if (item != minNumber)
                {
                    aggre.Remove(minNumber);
                    Console.WriteLine(item);
                }
            }
            return aggre;
            //for (int i = 0; i < length; i++)
            //{

            //}




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

        }
    }
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
}



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
