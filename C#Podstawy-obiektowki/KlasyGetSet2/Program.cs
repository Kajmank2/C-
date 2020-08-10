using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyGetSet2
{
    class Program
    {

        
            static void Main()
            {
                Employee employee1 = new Employee();
                employee1.Initialize(42);
                // BŁĄD nie można przypisać wartości do właściwości
                // lub indeksera 'Employee.Id'. Ten element służy tylko do odczytu.
                // employee1.Id = "490";
            }
        }
        class Employee
        {
            public void Initialize(int id)
            {
                // Używanie pola, ponieważ właściwość Id nie ma settera
                // (jest przeznaczona tylko do odczytu).
                _Id = id.ToString();
            }
            // …
            // Deklaracja właściwości Id.
            public string Id
            {
                get
                {
                    return _Id;
                }
                // Brak settera.
            }
            private string _Id;
        }
    }

