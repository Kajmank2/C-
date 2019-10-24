using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_Gra_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac[] p = new Postac[3];
            p[0] = new Mag();
            p[1] = new Warrior();
            

            Postac.wypiszEmlementy(p);

            TeamOfHeroes tof = new TeamOfHeroes("czytelncy", p[0]);
            Warrior warrior = new Warrior("Kot", 12, 36);
            Console.WriteLine(warrior);
            List<Postac> t = new List<Postac>();
            t.Add(new Warrior());
            t.Add(new Mag());

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            TeamOfHeroes th = new TeamOfHeroes("opeki" , new Postac("Janusz",1),new Postac("Karol",.23));
            th.OpiszDruzynke();
            Console.ReadKey();
        }

    }
    class Postac
    { 

        public string Name { get; private set; }
        public double Vitality { get; set; }

        public Postac()
        {
            Name = "Janko";
            Vitality = 1d;
        }
        public Postac(string name, double vitality)
        {
            this.Name = name;
            this.Vitality = vitality;
        }

        public static void wypiszEmlementy(Postac[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                if (osoby[i] != null)
                {
                    Console.WriteLine(osoby[i]);
                }
            }
        }
    }

    class Warrior : Postac
    {
        public string Name { get; private set; }
        private int Strenght { get; set; }
        private double Vitality { get; set; }

        public Warrior(string name, int strenght, int vitality) : base(name, vitality)
        {
            this.Name = name;
            this.Strenght = strenght;
            this.Vitality = vitality;
        }
        public Warrior()
        {
            this.Name = "Geralt";
            this.Vitality = 1d;
            this.Strenght = genStrenght();
        }
        public int genStrenght()
        {
            Random rand = new Random();
            int randNum = rand.Next(3, 19);
            this.Strenght = randNum;
            return this.Strenght;
        }

        public void ZmienHp(double hp)
        {
            if (hp > 1d || hp < 0)
                try
                {
                    throw new MyStrenghtException("musisz wprowadzic liczbe typu Double od 0 do 1 aby uzyskaz zywotnosc w procentach");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); ;
                    throw;
                }
            else
                this.Vitality = hp;
        }
        public override string ToString()
        {
            return "imie Wojownika to " + this.Name + "  ||Sila wojownika to " + this.Strenght + "  || % zdrowia wojownika to : " + this.Vitality.ToString("P", CultureInfo.InvariantCulture); // zamiana wartosci na %
        }
        public double Power()
        {
            int strengh = 0;
            double vitality = 0;

            strengh = this.Strenght;
            vitality = this.Vitality;
            if (Vitality <= 0.05)
                return strengh;
            else
                return strengh * vitality;
        }
    }
    class Mag : Postac
    {
        public string Name { get; private set; }
        private double Vitality { get; set; }
        private int Strenght { get; set; }
        private int MagicPoints { get; set; }

        public Mag(string name, double vitality, int strenght, int magicPoints) : base(name, vitality)
        {
            this.Name = name;
            this.Vitality = vitality;
            this.Strenght = strenght;
            this.MagicPoints = magicPoints;
        }
        public Mag()
        {
            this.Name = "Xardas";
            this.Vitality = 0.5;
            this.Strenght = genStrenght();
            this.MagicPoints = genMagicPoints();
        }
        public override string ToString()
        {
            return "imie Maga to " + this.Name + "  ||Sila Maga to " + this.Strenght + "  || % zdrowia wojownika to : " + this.Vitality.ToString("P", CultureInfo.InvariantCulture) + "Magic Pointsy maga to" + this.MagicPoints; // zamiana wartosci na %
        }
        public void ZmienHp(double hp)
        {
            if (hp > 1d || hp < 0)
                try
                {
                    throw new MyStrenghtException("musisz wprowadzic liczbe typu Double od 0 do 1 aby uzyskaz zywotnosc w procentach");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); ;
                    throw;
                }
            else
                this.Vitality = hp;
        }
        public int genStrenght()
        {
            Random rand2 = new Random();
            int randNum = rand2.Next(1, 7);
            this.Strenght = randNum;
            return this.Strenght;
        }
        public int genMagicPoints()
        {
            Random rand1 = new Random();
            int randNum = rand1.Next(2, 13);
            this.MagicPoints = randNum;
            return MagicPoints; ;
        }
        public double Power()
        {
            int strengh = 0;
            double vitality = 0;
            int pm = 0;
            pm = this.MagicPoints;
            strengh = this.Strenght;
            vitality = this.Vitality;

            return (pm + strengh) * vitality;
        }
    }

}



class MyStrenghtException : Exception
{
    public MyStrenghtException(string msg) : base(msg)
    {

    }
}

