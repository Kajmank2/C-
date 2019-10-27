using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweZadankoSamochod
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod sam1 = new Bmw("czerwone", "bmw", 3200, "ex32");
            Samochod sam2 = new Seat("Bialy", "Seat", 32111, "toledo 2003");
            Console.WriteLine(sam1.Wypisz());
            Console.WriteLine(sam2.Wypisz());

            ArrayList ar = new ArrayList();
            ar.Add(sam1.Wypisz());
            ar.Add(sam2.Wypisz());

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        abstract class Samochod
        {
            public string Color { get; set; }
            public string Mark { get; set; }
            public int Capacity { get; set; }
            public Samochod(string color, string mark, int capacity)
            {
                this.Color = color;
                this.Capacity = capacity;
                this.Mark = mark;
            }
            abstract public string Wypisz();

        }
        class Bmw : Samochod
        {
            private string Model;
            public Bmw(string color, string mark, int capacity, string model) : base(color, mark, capacity)
            {
                this.Model = model;
            }
            public override string Wypisz()
            {
                return this.Color + " " + this.Capacity + " " + this.Mark + Model;

            }
        }
            class Seat : Samochod
            {
                private string Model;
                public Seat(string color, string mark, int capacity, string model) : base(color, mark, capacity)
                {
                    this.Model = model;
                }
                public override string Wypisz()
                {
                    return this.Color + " " + this.Capacity + " " + this.Mark + Model;
                }
            }
        }
    }
