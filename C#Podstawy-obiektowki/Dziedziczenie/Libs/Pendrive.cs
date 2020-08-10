using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Libs
{
abstract    class Pendrive
    {
        protected string _color;
        public int pub_x = 10;
        private int prv_x = 10;
        protected int pro_x = 10;
        internal int int_x = 10;

        public void RecordData(string data)
        {
            Console.WriteLine("nagrywam dane {0} na {1}", data, GetType().Name);
        }
        public abstract void SetColor(string color);
        public abstract string GetColor();// wymusze na innych deklaracje
    }

}
