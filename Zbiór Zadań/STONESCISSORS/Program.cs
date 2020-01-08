using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STONESCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hi Evrybody, that is (rock,scissor paper) GAME. 
            // Only what you need it is NUMBER(0-2),
            // 0-Scissors(8-<) , 1-ROCK(0) , 2-Paper(||), 
            //GOOD LUCK AND HAVE FUN ! GREETINGS TO ALL ! 
            var random = new Random();
            string[] arr = new string[3] { "8-<", "0", "||" };
            int computerRand;
            Console.WriteLine("Input number (0-2) 0-Scissors(8-<) , 1-ROCK(0) , 2-Paper(||)");
            int mythings = Convert.ToInt32(Console.ReadLine());
            computerRand = random.Next(0, 3);
            try
            {
                if (mythings > 3)
                    throw new MyException("INPUT 0<=NUMBER<3");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == mythings)
                    {
                        Console.WriteLine("Your CHOICE =   {0}", arr[i]);
                    }
                    if (i == computerRand)
                    {
                        Console.WriteLine("Computer CHOICE =   {0}", arr[i]);
                    }
                }
                if (computerRand == mythings)
                {
                    Console.WriteLine("RESULT ----------------->DRAW !  ");
                }
                else
                if ((mythings == 0 & computerRand == 1) || (mythings == 1 & computerRand == 3) || (mythings == 2 & computerRand == 0))
                {
                    Console.WriteLine("RESULT ----------------->ComputerWIN");
                }
                else
                    Console.WriteLine("RESULT ----------------->YOUWINNING ! Congratulation");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }      

            Console.ReadLine();
        }


        public class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }
    }
}

