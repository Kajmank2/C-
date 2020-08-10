using ConsoleApp1.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 =
             new Employee();
            Employee employee2 =
             new Employee();
            // Wywołanie settera właściwości FirstName.
            employee1.FirstName = "Inigo";
            // Wywołanie gettera właściwości FirstName.
            Console.WriteLine(employee1.FirstName);
            // Przypisanie wartości do automatycznie zaimplementowanej właściwości.
            employee2.Title = "Maniak komputerowy";
            employee2.FirstName = "smiec";
            employee2.LastName = "s"; // throw w LAst Name 
            employee1.Manager = employee2;
            // Wyświetlanie stanowiska menedżera osoby reprezentowanej przez obiekt employee1.
            Console.WriteLine(employee1.Manager.Title);
            Console.WriteLine( $"{employee2.FirstName} , {employee2.Salary},{employee2.LastName}");
            Console.ReadKey();
        }
    }
}
