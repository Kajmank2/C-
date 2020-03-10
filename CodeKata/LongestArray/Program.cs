using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using LongestArray.CleanUp;

namespace LongestArray
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AmazonItem> az = new List<AmazonItem>();
            az.Add(new AmazonItem() { Category = "Main Category", Name = "Camera 1" });
            az.Add(new AmazonItem() { Category = "Main Category", Name = "Camera 2" });
            az.Add(new AmazonItem() { Category = "Main Category", Name = "Camera 3" });
            az.Add(new AmazonItem() { Category = "Main Category", Name = "Camera 4" });
            az.Add(new AmazonItem() { Category = "Main Category", Name = "Camera Stick" });
            az.Add(new AmazonItem() { Category = "Garbage", Name = "battery" });
            az.Add(new AmazonItem() { Category = "Garbage", Name = "bottle" });
            az.Add(new AmazonItem() { Category = "Notebooks", Name = "Asus Model#1" });

            foreach (var item in az)
            {
                Console.WriteLine(item);
            }

            List<AmazonItem> az2 =new List<AmazonItem>( AmazonWorker.LeaveOnlyMainCategoryItems(az));
            foreach (var item in az2)
            {
                Console.WriteLine("{0},{1}",item.Category, item.Name);
            }
            Console.ReadKey();
        }
    }
}

    //        string[] arr;
    //        int n, i;
    //        Console.WriteLine("Input number of strings to  store in the array :");
    //        n = Convert.ToInt32(Console.ReadLine());
    //        arr = new string[n];
    //        Console.WriteLine(" Input {0} strings for the array :\n", n);
    //        for (i = 0; i < n; i++)
    //        {
    //            Console.WriteLine("Element[{0}] : ", i);
    //            arr[i] = Console.ReadLine();
    //        }

    //        Console.WriteLine(LongestConsec(arr, 2));
    //        Console.ReadKey();
    //    }

    //    public static String LongestConsec(string[] strarr, int k)
    //    {
    //        var dict = new Dictionary<string, int>();
    //        for (int i = 0; i < strarr.Length; i++)
    //        {
    //            if (!dict.ContainsKey(strarr[i]))  
    //            {
    //                dict.Add(strarr[i], i + 1);
    //            }
    //        }
    //        string final = String.Join("",
    //       dict.OrderByDescending(s => s.Key.Length)
    //           .Take(k)
    //           .OrderBy(s => s.Value)
    //           .Select(s => s.Key)
    //   );

    //        return final;
    //    }

    //    }
    //}

