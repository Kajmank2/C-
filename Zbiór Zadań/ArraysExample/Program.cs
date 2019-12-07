using System;
using System.Linq;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] tab = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine("element{0} = {1}", i, 1);
            //    }
            //    else
            //        Console.WriteLine("element{0} = {0}", i);
            //}
            #endregion
            #region
            //int[] arr;
            //Console.WriteLine("Podaj RAnge");
            //int b = Convert.ToInt32(Console.ReadLine());
            //arr = new int[b];
            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine("wprowadz liczbe {0} do tablic", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = b - 1; i >= 0; i--)  // b-1 ostatnia literka
            //{
            //    Console.WriteLine("{0}", arr[i]);
            //}
            #endregion
            //int sum = 0;
            //int[] ar = new int[3] { 2, 3, 4 };
            //for (int i = 0; i <3; i++)
            //{
            //    sum += ar[i];

            //}
            //Console.WriteLine(sum);
            #region
            //int duplicate = 0;
            //int[] arr;
            //int b = Convert.ToInt32(Console.ReadLine());
            //arr = new int[b];
            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine("liczba nr 1 {0}", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region array kopiujacy
            //int[] arr1 = new int[100];
            //int[] arr2 = new int[100];
            //int i, n;
            //Console.WriteLine("Ilosc elementow w aARRayu");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Liczba nr 1 w tablicy", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //{
            //    arr2[i] = arr1[i];
            //}
            //Console.WriteLine("\n The elements stored in the firs array are :\n");
            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("{0} ", arr1[i]);
            //}
            //Console.WriteLine("Elementy w 2 array");
            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("{0}", arr2[i]);
            //}
            //for (i = n - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("arr po transofmarcji{0}", arr1[i]);
            //}
            #endregion
            #region w tablicy dupliakcje
            //int[] arr1 = new int[100];
            //int[] arr2 = new int[100];
            //int[] arr3 = new int[100];
            //int s1, s2, mm = 1, ctr = 0;
            //int i, j;


            //Console.WriteLine("Size of array : ");
            //s1 = Convert.ToInt32(Console.ReadLine());

            //for ( i = 0; i < s1; i++)
            //{
            //    Console.WriteLine("Numer{0} w tablicy to ",i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for ( i = 0; i < s1; i++)
            //{
            //    arr2[i]= arr1[i];
            //    arr3[i] = 0;
            //}
            //for (i = 0; i < s1; i++)
            //{
            //    for ( j = 0; j < s1; j++)
            //    {
            //        if (arr1[i] == arr2[j])
            //        {
            //            arr3[j] = mm;
            //            mm++;
            //        }
            //    }
            //    mm = 1;
            //}
            //for ( i = 0; i < s1; i++)
            //{
            //    if (arr3[i] == 2) { ctr++; } 
            //}
            //Console.WriteLine("the numer of duplicate is {0} \n" ,ctr);
            //Console.ReadKey();
            #endregion
            #region
            //int[] arr1;
            //int[] arr2;
            //Console.WriteLine("Zakres dla tablicy nr 1");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("zakres dla tablicy nr 2 ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //arr1 = new int[n];
            //arr2 = new int[m];
            //int[] arr3;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Pozycja nr {0}" ,i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine("Pozycja nr {0}", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            //var sqFrq = from x in arr1 group x by x into y select y;

            //foreach (var item in sqFrq)
            //{
            //    Console.WriteLine(item.Count());
            //}
            #endregion

            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;
            Console.WriteLine("Wprwoadz zakes N :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Elemnt -{0}", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                for (j = 0; j < i - 1; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                }
                /*Print the value of the current position of the array as unique value 
                when counter remain contains its initial value.*/
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");
        }
    }
}

