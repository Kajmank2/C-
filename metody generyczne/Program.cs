using System;

namespace metody_generyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string c = "lala";
            string d = "fifif";
            Swap<int>(ref a,ref b);  // on sie sam domysla 
            Swap<string>(ref c, ref d);
            Console.WriteLine(" liczba a{0},liczb b{1}, stringi to {2} i kolejny to {3}",a,b,c,d); 
            Console.ReadLine();
        }
        //public static void Swap(ref int a ,ref int b) //do kazdej metody trzeba robic oddzielnie podmianke
        //{
        //    int tmp;
        //    tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        public static void Swap<T>(ref T a, ref T b) //do kazdej metody trzeba robic oddzielnie
        {
            T tmp; // T - zmienna podmieniana
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
