using System;

namespace Zabawa_z_metodami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-4));
            Console.WriteLine("Hello World!");
        }

        class Math
        {
            public static int  Abs(int x)
            {
                if (x < 0)
                    return x * (-1);
                return x;
            }
        }
    }

}
