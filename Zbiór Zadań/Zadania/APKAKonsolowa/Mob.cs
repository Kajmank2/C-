using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APKAKonsolowa
{
    class Mob
    {
        public int Health { get; set; }
        private int[] Damage { get; set; }


        public Mob()
        {
            this.Health = 100;
            this.Damage = new int[] { 8, 11 };
        }
        public int GenrateSlash()
        {
            var random = new Random();
            return random.Next(Damage[0], Damage[1]);
        }
        public void PrzyjmijObrazenia(int obrazenia)
        {
            this.Health = this.Health - obrazenia;
        }
    }
}
