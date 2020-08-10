using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASY2.Libs
{
    class DataStorage
    {
        
        public static Employee Load(string firstName, string lastName)
        {
            Employee employee = new Employee();
            // Tworzenie obiektu typu FileStream dla pliku o nazwie
            // FirstNameLastName.dat. Parametr FileMode.Open powoduje
            // otwarcie istniejącego pliku lub zgłoszenie błędu.
            FileStream stream = new FileStream(
                 firstName + lastName + ".dat", FileMode.Open); 
// Tworzenie obiektu typu StreamReader przeznaczonego do odczytu tekstu z pliku.
StreamReader reader = new StreamReader(stream);
            // Wczytywanie każdego wiersza z pliku i zapisywanie
            // danych w odpowiedniej właściwości.
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.salary = reader.ReadLine();
            // Zamykanie obiektu typu StreamReader i powiązanego z nim strumienia.
            reader.Close(); // Automatycznie zamyka strumień.
            return employee;
        }
            // Zapis obiektu employee w pliku o nazwie
            // odpowiadającej imieniu i nazwisku pracownika.
            // Kod do obsługi błędów został pominięty.
            public static void Store(Employee employee)
        {
            // Tworzenie obiektu typu FileStream z nazwą pliku
            // FirstNameLastName.dat. Parametr FileMode.Create powoduje
            // utworzenie nowego pliku lub zastąpienie zawartości istniejącego.
            FileStream stream = new FileStream(
             employee.FirstName + employee.LastName + ".dat",
             FileMode.Create); 
// Tworzenie obiektu typu StreamWriter na potrzeby zapisu
// tekstu w obiekcie typu FileStream.
            StreamWriter writer = new StreamWriter(stream);
            // Zapis wszystkich danych dotyczących pracownika.
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.salary);
            // Zamyka obiekt typu StreamWriter i powiązany z nim strumień.
            writer.Close(); // Automatycznie zamyka strumień.
        }
        // …
    }
}
