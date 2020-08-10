using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program// klasy statyczne
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 4,123,3211,123 };

            for (int count = 0; count < args.Length; count++)
            {
                numbers[count] = args[count].Length;
            }
            Console.WriteLine($@"dlugosc najduzleszczego argumentu ={SimpleMath.Max(numbers)}");
            Console.WriteLine($@"dlugosc najkrutszego argumentu ={SimpleMath.Min(numbers)}");
            Console.ReadKey();
        }
    }
}
