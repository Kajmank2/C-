using System;

namespace YTKRS
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Zwierze();
            Kot kot = new Kot();
            Kot kot2 = zwierze as Kot;
            
   
            if (!(kot2  == null))
            {
                Console.WriteLine("Powiodlo sie");
            }
            else
            {
                Console.WriteLine("Nie powiodło się ");
            }

            Console.ReadKey();
        }
    }
    class Zwierze
    {
        public void DajGłos()
        {
            
            Console.WriteLine("Domyslny glos");
        }
    }
    class Kot : Zwierze
    {
        public void PijMleko()
        {
            Console.WriteLine("miaaaaau");
        }
    }
}
