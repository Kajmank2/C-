using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public static class SimpleMath
    {
        public static int Max(params int[] numbers)
        {
            if(numbers.Length == 0)
            {
                throw new ArgumentException(
                    "Tablica nie moze byc pusta", "numbers");
            }
            int result;
            result = numbers[0];
            foreach(int number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
        public static int Min(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException(
                    "Tablica nie moze byc pusta", "numbers");
            }
            int result;
            result = numbers[0];
            foreach (int number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }
    }
}
