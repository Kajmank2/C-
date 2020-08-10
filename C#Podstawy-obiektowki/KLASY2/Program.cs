using KLASY2.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASY2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.SetFirstName("Karolinka");
            Console.WriteLine(employee1.GetFirstName());

            Employee employee3 = new Employee();
            employee3.FirstName = "zdzisio";
            Console.WriteLine(employee3.FirstName);

            Employee employee2 = new Employee();
            employee2.SetName("JASIEK", "Fasola");
            #region Datastorage
           //employee2.Save(); DataSTORAGe Dla EMPLOJOW
           //// Modyfikowanie obiektu employee2 po jego zapisaniu.
           //IncreaseSalary(employee2);
           //// Wczytywanie danych obiektu employee1 z zapisanej wersji obiektu employee2.
           //employee1 = DataStorage.Load("Inigo", "Montoya");
           //Console.WriteLine(
           // $"{ employee1.GetName() }: { employee1.salary }");
            #endregion
           Console.ReadKey();
        }
        static void IncreaseSalary(Employee employee)
        {
            employee.salary = "Wystarczające, by przeżyć";
        }
    }
}
