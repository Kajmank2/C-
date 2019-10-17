using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazenieOperatorow_KonstruktorKopiujacy
{
    class Program
    {
        static void Main(string[] args) 
        {
            StanKonta a = new StanKonta(5, 10);
            StanKonta b = new StanKonta(5, 10);
            Console.WriteLine(a);
            Console.WriteLine(a + b);
            Console.WriteLine(332 / 100);
            Console.ReadKey();
        }
    }
    class StanKonta
    {
        public StanKonta(StanKonta k)
        {
            this.Gr = k.Gr;
            this.Zl = k.Zl;
        }
        public uint Zl { get; private set; }
        private ushort gr;
        public ushort Gr
        {
            get
            {
                return this.gr;
            }
            set
            {
                if (value <= 0)
                    this.gr = 0;
                else if(value >= 100)
                {
                    uint zlotychWGroszach = (uint)(value / 100);
                    Zl += zlotychWGroszach;
                    this.gr = (ushort)(value - zlotychWGroszach * 100);
                    /*
                     * uint - do ....
                     * int - do +
                     */
                }
                this.gr = value;
            }
        }
        public StanKonta(uint zl, ushort gr)
        {
            this.Zl = zl;
            this.Gr = gr;
        }
       public static bool operator ==(StanKonta L , StanKonta P)
        {
            if (L.Gr == P.Gr && L.Zl == P.Zl)
                return true;
            return false;
        }
        public static bool operator !=(StanKonta L , StanKonta P)
        {
            return !(L == P);
        }
        public override string ToString()
        {
            return Zl + "zl i" + Gr + "groszy";
        }
        public static StanKonta operator +(StanKonta L , StanKonta P) // jezeli damy + automatycznie sie ona wykonuje
        {
            uint tmpZl = L.Zl + P.Zl;
            ushort tmpGr = (ushort)(L.Gr + P.Gr);
            uint zlotychWGroszach = (uint)(tmpGr / 100);
            tmpZl += zlotychWGroszach;
            tmpGr = (ushort)(tmpGr - zlotychWGroszach * 100);


            return new StanKonta(tmpZl, tmpGr); //zwaracamy miejsce w pamieci z wartosciami tymaczasowymi
        }


        public override bool Equals(object obj) //Get HashCOde - sluzy do porwnania 
        {
            if (!(obj is StanKonta))
                return false;
            return (this == (StanKonta)obj);
        }
    }

}

            
