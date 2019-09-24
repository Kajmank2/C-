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

            //Liczby
            Console.WriteLine("Witaj dziisaj trenujemy");
            //Console.WriteLine("Podaj swoja liczbe");
            //int x = int.Parse(Console.ReadLine());
            //Zmienne.Porownaj(x);
            Console.WriteLine(Zmienne.IncreseBy2(20));

            //Playerek
            Player player = new Player("Karol");
            Player player1 = new Player("Zdzis");
            player1.setName("Siemanko");
            Player player2 = new Player("Zdzis");
            Console.WriteLine("{0},{1},{2}",player.Nickname,player1.Nickname,player2.Nickname);
            Console.WriteLine($"siemanko to gracz nr 1{player.Nickname}siema siema");


            Console.ReadKey();
        }
    }
    class Zmienne
    {
        int x;
        #region Porownanie
        public static void Porownaj(int x)
        {
            int mojaliczba = 1;
            if (mojaliczba>x)
                Console.WriteLine("huhu masz mniejsza liczbe od {0}",x);
            else
                Console.WriteLine("Masz wieksza liczbe szczesciarzu od {0}", x);           
        }
        #endregion
        public static int IncreseBy2(int num)
        {
            num *= 2;
            return num;
         }
    }

    class Player
    {
        int id;
        string nickname;
        static int nastepnyId = 0;

      public Player(string nick)
        {
            this.nickname = nick;
            nastepnyId++;
            nastepnyId = id;
        }
        public string setName(string nick ="Katolek")
        {
            this.nickname = nick;
            return nick;
        }
public string Nickname
        {
            get
            {
                return this.nickname;
            }
            set
            {
                this.nickname = value;
            }
        }
        public static int NastepnyId() {
            return nastepnyId;
        }
    }
}
