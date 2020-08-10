using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyKonstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
            new Employee("Karol","Kaim"),
            new Employee("Iza", "ska"),
            new Employee("Ola","Sirr")
            // parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        };
            emp.Add(new Employee("Iza", "dzidzi"));
            foreach (Employee empik in emp)
            {
                Console.WriteLine(empik.FirstName);
            }
            

            Console.WriteLine(emp);
            //Employee emp = new Employee("Karol", "Kaim") { Title = "Maniak komputerowy", Salary = "zaa niskie"};
            //emp.Salary = "za niskie";
            //Console.WriteLine($"{emp.FirstName} {emp.LastName } {emp.Salary } {emp.Title}");
            Console.ReadKey();
        }
    }
}
