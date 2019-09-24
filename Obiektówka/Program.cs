using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektówka
{
    class Program
    {
        #region Najprostsza Obiektówka
        //    static void Main(string[] args)
        //    {

        //        Czlowiek a = new Czlowiek();
        //        Czlowiek b = new Czlowiek();
        //        a.SetName();
        //        a.getName();
        //        b.SetName2("Karol");
        //        Console.WriteLine(a.getName());
        //        Console.WriteLine(b.getName());
        //        Console.ReadKey();

        //    }
        //class Czlowiek
        //    {
        //     string name = "arkadiusz";
        //     public   string getName()
        //        {
        //            Console.WriteLine(name);
        //            return name;
        //        }
        //        public void SetName()
        //        {
        //            name = "Witek";
        //        }
        //        public void SetName2(string imie)
        //        {
        //            this.name = imie;
        //        }
        //    }

        //}
        #endregion
        //Konstruktorek
        static void Main(string[] args)
        {
            Console.WriteLine(Gracz.NastepnyId()); // Zabezpieczone wszystko najlepiej robic Get - Pobierz   / Set Ustaw 
            Gracz[] gracz = new Gracz[3];
            gracz[0] = new Gracz("Karol");
            gracz[1] = new Gracz("Karol2");
            gracz[2] = new Gracz("Karol3");
            Console.WriteLine(gracz[0].Id);
            Console.WriteLine(gracz[1].Id);
            Console.WriteLine(gracz[2].Id);
          //  Console.WriteLine(Matematyk.dodaj(10,20));
          
            //Gracz gracz = new Gracz("Misiek");
            //Gracz gracz2 = new Gracz("Karolek");
            //if (gracz.Nick == null)
            //    Console.WriteLine("Graczyk bez nicku");
            //else
            //    Console.WriteLine(gracz.Nick);
            //Console.WriteLine(gracz.Id);
            //Console.WriteLine(gracz2.Nick);
            //Console.WriteLine(gracz2.Id);



            Console.ReadLine();
        }
        class Matematyk
        {
            public static int dodaj(int a , int b)
            {
                return a + b;
            }
        }
        class Gracz
        {
            public Gracz(string nick)
            {
                this.nick = nick;
                nastepnyId++;
                id = nastepnyId;
                
            }
            string nick;
            int id;
            static int nastepnyId = 0;

            public string Nick
            {
                get
                {
                    return this.nick;
                }
                set
                {
                    this.nick = value; //wartosc
                }
            }
            public void CheckId(int idd)
               
            {
                this.id = idd;
                if(idd == idd)
                {
                    idd++;
                }
                else
                {
                    Console.WriteLine("nie ma żadnych takich samych Id");
                }
            }

            public static int NastepnyId()
            {
                return nastepnyId;
            }
            public int Id
            {
                get
                {
                    return this.id;
                }
            }
        }

    }
}
