using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs
{
    class Program //interfejsy to co mamy przed twarza nie interesuje nas jak to sie robi
    {
        static void Main(string[] args)
        {
            IKontoBankowe a = new KontoA();
            IKontoBankowe b = new KontoA();
            IKontoBankowe ab = new KontoB();
            a.Wplac(500);
            b.Wplac(500);
            a.PrzetransferujDo(b, 200);
            a.PrzetransferujDo(ab, 100);
            Console.WriteLine(a.Saldo);
            Console.WriteLine(b.Saldo);
            Console.WriteLine(ab.Saldo);
            Console.ReadLine();
        }
    }
    interface IKontoBankowe // wszystkie metody w interejsie musza byc takie same we wszystkich Klasach
    {
        decimal Saldo { get; }

        void Wplac(decimal ilosc);
        bool Wyplac(decimal ilosc);
        bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc);
    }

    class KontoA : IKontoBankowe
    {
        private decimal saldo;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }
       public void Wplac(decimal ilosc)
        {
            saldo += ilosc; 
        }
        public bool Wyplac(decimal ilosc)
        {
            if (saldo > ilosc) { 
                saldo -= ilosc;
                return true;
                    }
            Console.WriteLine("za malo funduszy a koncie");
            return false;
        }
       public bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc)
        {
            bool wyplacono = this.Wyplac(ilosc);
                if(wyplacono)
                cel.Wplac(ilosc);
            return wyplacono;
        }

    }
    class KontoB : IKontoBankowe
    {
        private decimal saldo;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }
        public void Wplac(decimal ilosc)
        {
            saldo += ilosc;
        }
        public bool Wyplac(decimal ilosc)
        {
            if (saldo > ilosc)
            {
                saldo -= ilosc;
                return true;
            }
            Console.WriteLine("za malo funduszy a koncie");
            return false;
        }
        public bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc)
        {
            bool wyplacono = this.Wyplac(ilosc);
            if (wyplacono)
                cel.Wplac(ilosc);
            return wyplacono;
        }

    }

    #region
    //interface IEkran
    //{
    //    void Wyswietl();
    //}
    //interface IPanelPrzyciskow
    //{

    //}
    //class Monitor : IEkran, IPanelPrzyciskow
    //{
    //    public void Wyswietl() // zawsze musi byc public w Dzie dziczeniu klasa moze dziedziczyc tylko po jednej klasie bazowej

    //    {

    //    }
    //}
    #endregion
}
