using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaSklep
{
  public  class Warzywniak
    {
        private string _nazwa;
        private List<Obiekty> _lista;
        public Warzywniak(string nazwa)
        {
            this._nazwa = nazwa;
            this._lista = new List<Obiekty>();
        }
        public void Dodaj(Obiekty obiekty)
        {
            _lista.Add(obiekty);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rodzaj SKlepu " + _nazwa);
            for (int i = 0; i < _lista.Count; i++)
            {
                sb.AppendLine(_lista[i].ToString());
            }
            return sb.ToString();
        }
        public bool EquealCena(Cena cena1 , Cena cena2)
        {
            if (cena1 == cena2)
            {
                Console.WriteLine("Ceny są takie same !");
                return true;
                
            }
            else
            {
                Console.WriteLine("Te produkty maja różna cene");
                return false;
            }
        }
       



        //sb.AppendLine("Druzyna: " + _nazwa);
        //    sb.AppendLine("Suma ataku: " + this.SumaAtaku());
        //    for (int i = 0; i<_lista.Count; i++)
        //    {
        //        sb.AppendLine(_lista[i].ToString());
        //    }
        //    return sb.ToString();

    }
}
