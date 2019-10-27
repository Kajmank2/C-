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
            StanKonta a = new StanKonta(5, 88);
            StanKonta b = new StanKonta(5, 89);
            Console.WriteLine(a);
            Console.WriteLine(a + b);
            float e;
            e = a;
            Console.WriteLine(e);
            a=(StanKonta)5.99;
            Console.WriteLine(a.ToString()) ;
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
            return Zl + " zł i " + Gr + "gr";
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
        //Ukryte implicit //explit musimy zrobic dodatkowo rzutowanie
        public static implicit operator float(StanKonta value)
        {
            return value.Zl + (value.Gr /100.0f);
        }
        public static explicit operator StanKonta(float value) //explicipt jestem pewien ze tu jest pomylka
        {
            // ushort tmpGr = (ushort)((value - (uint)value)*100);
            ushort tmpGr = Convert.ToUInt16((value - (uint)value) * 100);
            return new StanKonta((uint)value, tmpGr);
        }
        //public static explicit operator StanKonta(float value) //(StanKonta)value;
        //{
        //    //ushort tmpGr = (ushort)((value - (uint)value) * 100);
        //    ushort tmpGr = Convert.ToUInt16((value - (uint)value) * 100);
        //    return new StanKonta((uint)value, tmpGr);

        //    //5.47 - 5 = 0.47 * 100 = 47
        //}
    }

}

            
