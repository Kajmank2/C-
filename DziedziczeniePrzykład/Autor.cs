using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziedziczeniePrzykład
{
    class Autor
    {
        public string Imie { get;protected set; }
        public int Wiek { get; protected set; }

        public Autor()
        {
            this.Imie = "arkadiusz";
            this.Wiek = 19;
        }
        public Autor(string Imie , int Wiek)
        {
            this.Imie = Imie;
            this.Wiek = Wiek;
        }
    }
}
