using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APKAKonsolowa
{
    class Czlowiek
    {
        public int Health { get; set; }
        private int[] Damage { get; set; }

        public Czlowiek()
        {
            this.Health = 100;
            this.Damage = new int[] { 8, 22 };
        }
        public int GenerateSlash()
        {
            var random = new Random();
            return random.Next(Damage[0], Damage[1]);
        }
        public void PrzyjmijObrazaenia(int obrazenia)
        {
            this.Health = this.Health - obrazenia;
        }
    }
}
