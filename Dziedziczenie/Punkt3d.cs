using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Punkt3d : Punkt
    {
        public int Z { get;  protected set; }
        public Punkt3d ( int X , int Y , int Z) : base(X,Y)
        {
            this.Z = Z;
        }
    override public string PobierzWsp() // nadpisuje upewniam kompilator dzieki temu nam wybiera
        {
            return base.PobierzWsp() +  ", " + this.Z;
        }
    }
}
