using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaSklep
{
   public class Cena
    {
        private uint _gr;
        private decimal _zl;
        public uint GR
        {
            get
            {
                return _gr;
            }
            set
            {
                if (_gr <= 0)
                    this._gr = 0;
                if (value > 100)
                {
                    decimal ZlotowkiWGroszach = value / 100;
                    Zl += ZlotowkiWGroszach;
                    _gr = (uint)(value - ZlotowkiWGroszach * 100);
                }
                this._gr = value;
            }
        }
        public decimal Zl;
        public Cena(decimal zl=0 , uint gr= 0)
        {
            this.Zl = zl;
            this.GR = gr;
        }
        public override string ToString()
        {
            return this.Zl + " " + this.GR + " ";
        }
    }
}
