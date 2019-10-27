using System;
using System.Collections;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tablice
            //int[] collection = { 1, 2, 3 , 4, 5 };
            //collection[1] = 3;

            //foreach (int i in collection)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(collection);
            //Aray List
            //ArrayList al = new ArrayList();
            //al.Add("LLorem ipsum");
            //al.Add("L23");
            //al.Add(33);
            //al.Insert(3, "Eduweb");
            //al.RemoveAt(1);//wrzucamy konkretny element na konkretnej pozycji w tym parametrze sie dodaje
            //Console.WriteLine(al.Count); //zliczanie elementow listy

            //foreach(object o in al)
            //{
            //    Console.WriteLine(o);
            //}
            // Array.Sort(collection);//sortowanie
            //STOS STOS STOS STOS STOS
            Stack st = new Stack();
            st.Push("lorem");
            st.Push(213);

            object o1 = st.Pop(); //sciaganie wartosci z gory
            object o2 = st.Peek(); //podgladamy
            Console.WriteLine(st.Count);
       
          
            Console.ReadLine();
        }
    }
}
