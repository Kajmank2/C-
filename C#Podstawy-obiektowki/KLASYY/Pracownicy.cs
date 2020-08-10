using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASYY
{
    class Pracownicy
    {
        public string FirstName;
        public string LastName;
        public string salary = "za niskie";

        public string GetName()
        {
            return $"{FirstName}{LastName}";
        }
        public void SetName(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Console.WriteLine($"Imie i nazwisko zmieniono na {this.GetName() }");
        }
    }
}
