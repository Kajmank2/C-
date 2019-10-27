using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczonka
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sumiki
            //Sumator sumik = new Sumator();
            ////Console.WriteLine(sumik.Suma());
            ////  sumik.SumaPodziel3();

            //Console.WriteLine(sumik.IleElementow());
            #endregion
            #region Numbers
            //Liczby
            //Console.WriteLine("Witaj dziisaj trenujemy");
            //Console.WriteLine(Zmienne.Poteguj(2, 10));
            //Console.WriteLine(Zmienne.Podziel(10,2));
            ////Console.WriteLine("Podaj swoja liczbe");
            ////int x = int.Parse(Console.ReadLine());
            ////Zmienne.Porownaj(x);
            //Console.WriteLine(Zmienne.IncreseBy2(20));
            #endregion
            #region Player
            //Playerek
            //Player[] player = new Player[10];
            //player[0] = new Player("Karol", 100);
            //player[1] = new Player("Zdzis", 100);
            //player[1].setName("Siemanko");
            //Console.WriteLine("{0},{1}", player[0].Nickname, player[1].Nickname);
            //Console.WriteLine($"siemanko to gracz nr 1 {player[1].Nickname} '\b' id ={player[1].Id} {player[0].Hp}");
            //Console.WriteLine($"siemanko to gracz nr 2 {player[0].Nickname} '\b' id ={player[0].Id}");
            #endregion
            #region Statyczna
            //Statyczna stat = new Statyczna();
            //Console.WriteLine(stat);
            //Console.WriteLine(Statyczna.Zwieksz(1));
            #endregion
            #region data
            // Data dt = new Data();
            // dt.data.AddDays(2);
            // dt.PokazDate();
            //// dt.DodajDate();
            //   dt.DataDoPrzodu();
            #endregion
            Osoba osoba = new Osoba("Karol" , "Karols" , 12);
            osoba.Imie = "jacek";
            osoba.Wypisz();
            Console.ReadKey();
        }
    }
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }

      public  Osoba(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public  void Wypisz()
        {
 
            Console.WriteLine($"Imie pracownika to {Imie}, nazwisko jego to {Nazwisko} a jego wiek to {Wiek}");
        }

        //class Data
        //{
        //   public DateTime data = DateTime.UtcNow.ToLocalTime();
        //    DateTime data1;
        //    DateTime data2;
        //    public DateTime DodajDate()
        //    {
        //     data1 = data.AddDays(365);
        //        return data;
        //    } 

        //    public  void PokazDate()
        //    {
        //        Console.WriteLine("Obecna data: " + data);
        //    }
        //    public void DataDoPrzodu()
        //    {
        //        DodajDate();
        //        Console.WriteLine("Data do przodu" + data1);
        //    }

        //}
        //class Zmienne
        //{
        //    int x;

        //    public static void Porownaj(int x)
        //    {
        //        int mojaliczba = 1;
        //        if (mojaliczba > x)
        //            Console.WriteLine("huhu masz mniejsza liczbe od {0}", x);
        //        else
        //            Console.WriteLine("Masz wieksza liczbe szczesciarzu od {0}", x);
        //    }

        //    public static int IncreseBy2(int num)
        //    {
        //        num *= 2;
        //        return num;
        //    }
        //    public static int Poteguj(int podstawaPotegi, int wykladnik)
        //    {
        //        int tmp = 1;
        //        for (int i = 0; i < wykladnik; i++)
        //        {
        //            tmp *= podstawaPotegi;

        //        }
        //        return tmp;
        //    }
        //    public static float Podziel(float dzielna, float dzielnik)
        //    {
        //        return dzielna / dzielnik;
        //    }

        //}

        //class Player
        //{
        //    private int id;
        //    string nickname;
        //    static int nastepnyId = 0;
        //    private int hp;

        //    public Player(string nick, int Hp)
        //    {
        //        this.nickname = nick;
        //        this.hp = Hp;
        //        nastepnyId++;
        //        id = nastepnyId;
        //    }
        //    public string setName(string nick = "Katolek")
        //    {
        //        this.nickname = nick;
        //        return nick;
        //    }
        //    public int Id
        //    {
        //        get
        //        {
        //            return this.id;
        //        }
        //    }
        //    public string Nickname
        //    {
        //        get
        //        {
        //            return this.nickname;
        //        }
        //        set
        //        {
        //            this.nickname = value;
        //        }
        //    }
        //    public int Hp
        //    {
        //        get
        //        {
        //            return this.hp;
        //        }
        //    }
        //    public static int NastepnyId()
        //    {
        //        return nastepnyId;
        //    }

        //}

        //class Sumator
        //{

        //private int[] liczby = new int[] { 1, 23, 22, 1, 13, 45, 3 };



        //    public int Suma()
        //    {
        //        int wynik = 0;
        //        for (int i = 0; i < liczby.Length; i++)
        //        {
        //            wynik += liczby[i];
        //        }
        //        return wynik;
        //    }
        //    public void SumaPodziel3()
        //    {
        //        int samson = 0;
        //        for (int i = 0; i < liczby.Length; i++)
        //        {
        //            if (liczby[i] % 3 == 0)
        //            {
        //                Console.WriteLine(liczby[i]);
        //                samson += liczby[i];
        //                Console.WriteLine(samson);

        //            }
        //        }
        //    }
        //    public int IleElementow()
        //    {
        //        int nastepny = 0;

        //        for (int i = 0; i < liczby.Length; i++)
        //        {
        //            liczby[i] = 0;
        //            liczby[i] = nastepny++;
        //        }
        //        return nastepny;
        //    }
        //}

        //class Statyczna
        //{
        //    int I;
        //    static int Liczba;

        //  public  static int Zwieksz(int liczba)
        //    {
        //        liczba++;
        //        Liczba = liczba;
        //        return liczba;
        //    }
        //    public Statyczna( int i = 10)
        //    {
        //        this.I = i;
        //        Zwieksz(i);
        //    }

        //    public Statyczna(Statyczna statyczna)
        //    {
        //        statyczna.I = 20;
        //    }

        }
    }
