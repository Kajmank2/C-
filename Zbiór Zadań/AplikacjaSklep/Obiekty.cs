using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaSklep
{
    public abstract class Obiekty : Cena
    {
        private  int _id;
        static int NextId;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        Cena _cena;
        public string Nazwa { get; }
        public string Rodzaj { get; }

        public Obiekty(string nazwa, string rodzaj , Cena cena)
        {
            this.Nazwa = nazwa;
            this.Rodzaj = rodzaj;
            NextId++;
            _id = NextId;
            this._cena = cena;
        }
        public abstract string Opis();
        public override string ToString()
        {
            return "ID: " + this.Id + " Nazwa:  " + this.Nazwa + " Cena: " + _cena;
        }
    }
}