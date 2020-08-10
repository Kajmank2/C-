using KLASY2.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASY2
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string salary = "za niskie";
        private string Password;
        private bool IsAuthenticated;

       // private string = FirstName; getter i setter
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string newFirstName)
        {
            if (newFirstName != null && newFirstName != "")
            {
                FirstName = newFirstName;
            }
        }

        private string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string newLastName)
        {
            if (newLastName != null && newLastName != "")
            {
                FirstName = newLastName;
            }
        }



        public bool Logon(string password)
        {
            if (Password == password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }
        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }

        public void Save()
        {
            DataStorage.Store(this);
        }

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
