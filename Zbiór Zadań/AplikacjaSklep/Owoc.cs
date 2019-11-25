using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaSklep
{
    public class Owoc : Obiekty
    {
        public bool JestOwocem { get; set; }
        public int IloscWitamin { get; set; }
        public Owoc(bool jestemOwocem, int iloscWitamin, string nazwa, string rodzaj,Cena cena) : base(nazwa, rodzaj,cena)
        {
            this.JestOwocem = jestemOwocem;
            this.IloscWitamin = iloscWitamin;
        }
        public override string Opis()
        {
            return this.Nazwa + " " + this.Rodzaj + " " + this.JestOwocem + " " + this.Rodzaj + " " + " " + this.Id;
        }
    }
    public class Warzywko : Obiekty
    {
        public bool JestemWarzywem;
        public int IloscMineralow;

        public Warzywko(string nazwa , string rodzaj , bool jestemWarzywem , int iloscMienralow,Cena cena)      : base(nazwa , rodzaj,cena)
        {
            this.JestemWarzywem = jestemWarzywem;
            this.IloscMineralow = iloscMienralow;
         
        }

        public override string Opis()
        {
            return this.Nazwa + " " + this.Rodzaj + " " + this.JestemWarzywem + " " + this.Rodzaj + " " +  " ID= " + this.Id;
        }
    }
    
}
