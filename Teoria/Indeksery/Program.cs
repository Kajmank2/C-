using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksery
{
    class Program
    {
        static void Main(string[] args)
        {
            Zdanie b = new Zdanie("to jest testowe zdanie");
            Console.WriteLine(b[0]);
            Console.ReadKey();
        }
    }
    class Zdanie
    {
        string[] slowa;
        public Zdanie(string zdanie)
        {
            this.slowa = zdanie.Split();
        }

        public string this[int n]//indekser
        {
            get
            {
                if (slowa.Length > n)
                    return slowa[n];
                else
                    return null;
            }
            set
            {
                slowa[n] = value;
            }
        }
    }
}
