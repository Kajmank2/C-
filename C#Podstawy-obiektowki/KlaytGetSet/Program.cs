using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nameof(C)); // -> "C"
            Console.WriteLine(nameof(C.Method1)); // -> "Method1"
            Console.WriteLine(nameof(C.Method2)); // -> "Method2"
            Console.WriteLine(nameof(c.Method1)); // -> "Method1"
            Console.WriteLine(nameof(c.Method2)); // -> "Method2"
                                                  // Console.WriteLine(nameof(z)); -> "z" [inside of Method2 ok, inside Method1 is a compiler error]
            Console.WriteLine(nameof(Stuff)); // -> "Stuff"
                                              // Console.WriteLine(nameof(T)); -> "T" [works inside of method but not in attributes on the method]
            Console.WriteLine(nameof(f)); // -> "f"
                                          // Console.WriteLine(nameof(f<T>)); -> [syntax error]
                                          // Console.WriteLine(nameof(f<>)); -> [syntax error]
        }
    }
}
