using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePhoneNumer(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            DisplayArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Console.ReadKey();
        }
        static void DisplayArray(int[] numbers) => Console.WriteLine(string.Join("(",numbers[0]));

        static void ChangeArrayE(int[] numbers)
        {
            numbers[0] = 2;
        }
        public static string CreatePhoneNumer(int[] numbers)
        {
            string[] result = numbers.Select(x => x.ToString()).ToArray();
            Console.WriteLine(result.ToString());
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
                return numbers.ToString();
        }
        public void SplitString(int[] numbers)
        {
                      
        }

        //a = a.Insert(0,"this is") - wstawia w to miejsce znaki
    }
}
