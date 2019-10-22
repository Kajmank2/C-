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
            Mag mag = new Mag();
            Warrior warrior = new Warrior();
            Console.WriteLine("Wojownik to {0} \n mag to {1}",warrior,mag);
            Console.ReadKey();
        }
    }

    class Warrior
    {
        public string Name { get;private set; }
        private int[] Strenght { get; set; }
        public double Vitality { get; private set; }

        public Warrior(string name , int[] strenght , int vitality)
        {
            this.Name = name;
            this.Strenght = strenght;
            this.Vitality = vitality;
        }
        public Warrior()
        {
            this.Name = "Geralt";
            this.Vitality = 1d;
            this.Strenght = new int[] { 3, 18 };
        }

        public int GenerateStrenght()
        {
            var random = new Random();
            return random.Next(Strenght[0], Strenght[1]);
        }
        public override string ToString()
        {
            return "imie Wojownika to " + this.Name + "  ||Sila wojownika to " + this.Strenght + "  || % zdrowia wojownika to : " + this.Vitality.ToString("P", CultureInfo.InvariantCulture); // zamiana wartosci na %
        }
    }
    class Mag
    {
        public string Name { get; private set; }
        public double Vitality{ get; set; }
        private int[] Strenght { get; set; }
        private int[] MagicPoints { get;  set; }

        public Mag(string name , double vitality ,int [] strenght ,int[] magicPoints)
        {
            this.Name = name;
            this.Vitality = vitality;
            this.Strenght = strenght;
            this.MagicPoints = magicPoints;
        }
        public Mag()
        {
            this.Name = "Xardas";
            this.Vitality = 1;
            this.Strenght = new int[] { 1, 6 };
            this.MagicPoints = new int[] { 2, 12 };
        }
    }
}
