using System;
using System.Collections.Generic;
using System.Linq;

namespace StringiLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            IEnumerable<string> stringLenght = cities.OrderBy(str => str.Length)
                            .ThenBy(str => str).ToList();
            var citySplit = from i in Enumerable.Range(0, cities.Length) group cities[i] by i/3;
            foreach (var item in stringLenght)
            {
                Console.WriteLine(item);
            }
            foreach (var item in citySplit)
            {
                Console.WriteLine(string.Join(" :  ",item.ToArray()));
            }
            Console.ReadKey();
        }
    }
}
