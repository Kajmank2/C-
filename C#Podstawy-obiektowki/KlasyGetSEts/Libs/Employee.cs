using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Libs
{
    class Employee
    { // Właściwość FirstName.
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        private string _FirstName;
        // Właściwość LastName.
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set { 
            //{
            //    _LastName = value;
            //}
            // Sprawdzanie poprawności w trakcie przypisywania wartości właściwości LastName.
            if (value == null)
            {
                // Zgłaszanie błędu.
                // W wersji C# 6.0 należy zastąpić value wywołaniem nameof(value).
                throw new ArgumentNullException(nameof(value));
            }
            else
            {
                // Usuwanie odstępów wokół nazwiska.
                value = value.Trim();
                if (value == "")
                {
                    // Zgłaszanie błędu.
                    // W wersji C# 6.0 zastąp value wywołaniem nameof(value).
                    throw newArgumentException(
                    "Właściwość LastName nie może być pusta.", "value"); 
                }
                else _LastName = value;
            }
            }
        }

        private Exception newArgumentException(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private string _LastName;

        public string Title { get; set; }
        public Employee Manager { get; set; }

        public string Salary { get; set; } = "Za niskie";
    }
}
