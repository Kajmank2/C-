using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Welcomer.Message);
            

            Car samochod = new Car("jakis opis");
            //Car samochod2 = samochod; //teraz edytujemy wszystko = sa takie same
            Car samochod2 = new Car(samochod);
            samochod2.Description = "Nowy Opis";
            //klasy przekazuja adres w pamieci komputera
            Console.WriteLine(samochod.Description);
            Console.WriteLine(samochod2.Description);

            Console.WriteLine(samochod.NrOfWheels);

            int a = 10;
            int b = a;
             b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }

        class Welcomer
        {
            public static string Message
            {
                get;
                private set;
            }
            static Welcomer()
            {
                DateTime now = DateTime.Now;
                if (now.Hour < 17)
                    Message = "DzienDoby";
                else
                    Message = "Dobry wieczór";
            }
        }
        class Car
        {
            public string Description
            {
                get; set;
            }
            public int NrOfWheels
            {
                get;
                private set;
            }
            public Car(string description, byte nrOfWheels = 4)
            {
                this.Description = description;
                this.NrOfWheels = nrOfWheels;
            }

            public Car (string description) : this(description, 4)
            {
                Console.WriteLine("LALLA");
            }
            public Car(Car samochod)
            {
                this.Description = samochod.Description;
                this.NrOfWheels = samochod.NrOfWheels;
                samochod.NrOfWheels = 30;
            }
            //Potrenowac !
        }
    }
}
