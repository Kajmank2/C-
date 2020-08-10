using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2
{
    class C
    {
        static int Method1(string x, int y) { }
        static int Method1(string x, string y) { }
        int Method2(int z) { }
        string f<T>() => nameof(T);
    }

    var c = new C();

