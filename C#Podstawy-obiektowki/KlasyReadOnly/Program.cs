using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyReadOnly
{
    class Program
    {
        // Definiowanie klasy zagnieżdżonej służącej do przetwarzania wiersza poleceń.

 private class CommandLine
        {
            public CommandLine(string[] arguments)
            {
                for (int argumentCounter = 0;
                argumentCounter < arguments.Length;
                argumentCounter++)
                {
                    switch (argumentCounter)
                    {
                        case 0:
                            Action = arguments[0].ToLower();
                            break;
                        case 1:
                            Id = arguments[1];
                            break;
                        case 2:
                            FirstName = arguments[2];
                            break;
                        case 3:
                            LastName = arguments[3];
                            break;
                    }
                }
            }
            public string Action;
            public string Id;
            public string FirstName;
            public string LastName;
        }
        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine(args);
            switch (commandLine.Action)
            {
                case "new":
                    // Tworzenie nowego obiektu reprezentującego pracownika.
                    // …
                    break;
                case "update":
                    // Aktualizowanie danych w istniejącym obiekcie reprezentującym pracownika.
                    // …
                    break;
                case "delete":
                    // Usuwanie pliku z danymi pracownika.
                    // …
                    break;
                default:
                    Console.WriteLine(
                    "Employee.exe " +
                    "new|update|delete <id> [imię] [nazwisko]");
                    break;
            }
            Console.ReadKey();
        }
    }
}
