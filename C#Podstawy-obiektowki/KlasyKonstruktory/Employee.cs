using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyKonstruktory
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Title { get; set; }
        public string Salary{ get; set; } = "za niskie";
        public Employee(string firstName , string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
