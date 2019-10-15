using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Punkt
    {
        public int X { get; protected  set; }
        public int Y { get; protected set; }
        public Punkt()
        {
            Console.WriteLine("Jestem Konstruktorem domyslnym z klasy Punkt");
            this.X = 0;
            this.Y = 0;
        }
        public Punkt(int X , int Y)
        {
            Console.WriteLine("Jestem kontruktorem z klasy Punkt z 2 parametrami");
            this.X = X;
            this.Y = Y;
        }
     virtual public string PobierzWsp() // tak powinno sie robic 
        {
            return this.Y + "," + this.X;
        }
    }
}
