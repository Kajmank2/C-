using System;
using System.Linq;

namespace LINQ5AdvancedCLASS
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] set1 = { 'X', 'Y', 'Z' };
            int[] set2 = { 1, 2, 3 };
            string[] set3 = { "Green", "Pink" };
            var cartsianProduct = from letter in set1
                                  from number in set2
                                  from colur in set3
                                  select new { letter, number, colur };
            foreach (var item in cartsianProduct)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================================================");

            Console.Write("\nLINQ : Generate a Cartesian Product of three sets: ");
            Console.Write("\n---------------------------------------------------\n");

            var set12CartesianProduct = set1.SelectMany( // select many wybiera wiele ale łaczy tylko 2 tabellki
                letterList => set2.Select(numList =>
                new { letterList, numList }));

            var cartesianProduct = set12CartesianProduct.SelectMany(
                (set1and2) => set3.Select(colorList =>
                new { set1and2.letterList, set1and2.numList, colorList }));

            Console.Write("The Cartesian Product are : \n");
            foreach (var ProductList in cartesianProduct)
            {
                Console.WriteLine(ProductList);
            }
            Console.ReadKey();
        }
    }
}
