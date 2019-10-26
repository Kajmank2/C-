using System;
using System.Collections.Generic;
namespace SortedDictionaryCwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> openWith =
                new SortedDictionary<int, string>();
            openWith.Add(1, "Kasztan");
            openWith.Add(3, "mistrz");
            openWith.Add(2, "koszykarz");
            openWith.Add(4, "Kasztan");
            openWith.Add(6, "koszykarz");

            try // tworzenie wyjatku jak cos sie powtorzy
            {
                openWith.Add(1, "Kasztan");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ten argument juz wystapil");
            }
            Console.WriteLine("For key = \"1\" ,value =  {0}", openWith[1]);

            openWith[2] = "siatkarz"; // podmianka w slowniku
            Console.WriteLine(openWith[2]);

            string value = "";
            if (openWith.TryGetValue(5, out value)) // jesli nie ma kluczyka to niestety nie znajdziemy wartosci 
            {
                Console.WriteLine("dla klucza = \"5\" , value{0}", value);
            }
            else
            {
                Console.WriteLine("key = \"5\" is not found");
            }
            if (!openWith.ContainsKey(3)) // jesli nieistnieje to dodaje nam swirka
            {
                openWith.Add(3, "optivia9");
                Console.WriteLine("Value added for key = \"3\": {0}",
                    openWith[3]);
            }
            foreach (KeyValuePair<int, string> kvp in openWith) // Sortowanie po koleji wszystko 
            {
                Console.WriteLine("Key = {0} , Value{1}", kvp.Key, kvp.Value);
            }
            // Sortowanie Kluczykow
            SortedDictionary<int, string>.KeyCollection keycoll = openWith.Keys;
            Console.WriteLine();

            foreach (var item in keycoll)
            {
                Console.WriteLine("Key = {0}", item);
            }
            //Sortowanie wartosci
            SortedDictionary<int, string>.ValueCollection valcoll = openWith.Values;
            foreach (var item in valcoll)
            {
                Console.WriteLine("value = {0}",item);
            }
            //Usuwanie i sprawdzanie czy element jest w naszym slowniku
            Console.WriteLine("Wlasnie usuwam 1 ");
            openWith.Remove(1);
                if (!openWith.ContainsKey(1))
            {
                Console.WriteLine("Key \"1\" not found");
            }
            foreach (KeyValuePair<int, string> kvp in openWith) // Sortowanie po koleji wszystko 
            {
                Console.WriteLine("Key = {0} , Value{1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
