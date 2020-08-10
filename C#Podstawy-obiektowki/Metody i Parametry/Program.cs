using  System;
using System.IO;

namespace Metody_i_Parametry
{
    class Program
    {
        #region
        static void DisplayGreeting(string fullyName, string initials)
        {
            Console.WriteLine($"Witaj , {fullyName} twoje inicjaly to {initials}");
        }
        static string getInitials(string firstName, string secondName)
        {
            return $"{firstName[0]}{secondName[0]}";
        }

        static string getFullyName(
          string firstName, string secondName)
        {
            //=> $"{firstName}{secondName}";

            return $"{firstName}{secondName}";
        }

        static string getUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {

            string firstName;
            string secondName;
            string fullyName;
            string initials;
            Console.WriteLine("Witam Cie");
            firstName = getUserInput("wprowadz imie: ");
            secondName = getUserInput("wprowadz nazwisko: ");


            fullyName = getFullyName(firstName, secondName);
            initials = getInitials(firstName, secondName);
            DisplayGreeting(fullyName, initials);
            Console.ReadLine();
            #endregion
            #region regionek z wysietlaniem sciezki wartosc
            //static void Main(string[] args)
            //{
            //    string fullName;
            //    string driveLetter = "C:";
            //    string folderPath = "Data";
            //    string fileName = "index.html";
            //    fullName = Combine(driveLetter, folderPath, fileName);
            //    Console.WriteLine(fullName);

            //}
            //static string Combine(
            //string driveLetter, string folderPath, string fileName)
            //{
            //    string path;
            //    path = string.Format("{1}{0}{2}{0}{3}",
            //     System.IO.Path.DirectorySeparatorChar,
            //     driveLetter, folderPath, fileName);
            //    return path;
            //}

            //static void Main(string[] args)
            //{
            //    int a = 10;
            //    int b = 112;
            //    int c = 998;
            //    int suma=sumNumber(a,b,c) ;
            //    Console.WriteLine(suma);
            //    Console.ReadKey();
            //}
            //static int sumNumber ( int a , int b , int c)
            //{
            //    int sumabc;
            //    sumabc = a+b+c;
            //    return sumabc;
            //}

            #endregion
            #region zamiana znakow
            //static void Main()
            //{
            //    // …
            //    string first = "Witaj";
            //    string second = "Żegnaj";
            //    Swap(ref first, ref second);
            //    Console.WriteLine(
            //     $@"first = ""{first}"", second = ""{second}""");
            //    // …
            //}
            //static void Swap(ref string x, ref string y) 
            //{
            //    string temp = x;
            //    x = y;
            //    y = temp;
            //}

            //static void Main()
            //{
            //    int a = 10;
            //    int b = 15;
            //    int c = 22;
            //    Swap(ref a, ref b, ref c);
            //    Console.WriteLine($"{a}, {b}, {c}");
            //}

            //private static void Swap(ref int x, ref int y, ref int z)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;

            //    int temp2 = z;
            //    temp2 = z;
            //    z = y;
            //    y = temp2;
            //}

            #endregion
            #region parametry wyjsciowe z modyfikatorem out
            // static int Main(string[] args)
            // {
            //     char button  ;
            //     if (args.Length == 0)
            //     {
            //         Console.WriteLine(
            //         "ConvertToPhoneNumber.exe <znaki>");
            //         Console.WriteLine(
            //         "'_' oznacza, że nie podano standardowego przycisku telefonu");
            //         return 1;
            //     }
            //     foreach (string word in args)
            //     {
            //         foreach (char character in word)
            //         {
            //             if (TryGetPhoneButton(character, out button))
            //             {
            //                 Console.Write(button);
            //             }
            //             else
            //             {
            //                 Console.Write('_');
            //             }
            //         }
            //     }
            //     Console.WriteLine();
            //     return 0;
            //     Console.ReadKey();
            // }
            //private static bool TryGetPhoneButton(char character, out char button)
            // {
            //     bool success = true;
            //     switch (char.ToLower(character))
            //     {
            //         case '1':
            //             button = '1';
            //             break;
            //         case '2': case 'a': case 'b': case 'c':

            //      button = '2';
            //             break;
            //         case '3':
            //             button = '3';
            //             break;
            //         case '4':
            //             button = '4';
            //             break;
            //         case '5':
            //             button = '5';
            //             break;
            //         case '6':
            //             button = '6';
            //             break;
            //         case '7':
            //             button = '7';
            //             break;
            //         case '8':
            //             button = '8';
            //             break;
            //         case '9':
            //             button = '9';
            //             break;
            //         case '0':
            //             button = '0';
            //             break;
            //         // …
            //         case '-':
            //             button = '-';
            //             break;
            //         default:
            //             // Przypisywanie do zmiennej button wartości oznaczającej nieprawidłowy znak
            //             button = '_';
            //             success = false;
            //             break;
            //     }
            //     return success;
            //        }
            #endregion
            #region tablice parametrow params()
            //static void Main()
            //{
            //    string fullName;
            //    // …
            //    // Wywołanie metody Combine() z czterema argumentami.
            //    fullName = Combine(
            //    Directory.GetCurrentDirectory(),
            //    "bin", "config", "index.html");
            //    Console.WriteLine(fullName);

            //    // Wywołanie metody Combine() z tylko trzema argumentami.
            //    fullName = Combine(
            //    Environment.SystemDirectory,
            //    "Temp", "index.html");
            //    Console.WriteLine(fullName);
            //    // …

            //    // Wywołanie metody Combine() z argumentem w postaci tablicy.
            //    fullName = Combine(
            //    new string[] {
            //"C:\\", "Data",
            //"HomeDir", "index.html"});
            //    Console.WriteLine(fullName);
            //    // …
            //}
            //static string Combine(params string[] paths)
            //{
            //    string result = string.Empty;
            //    foreach (string path in paths)
            //    {
            //        result = System.IO.Path.Combine(result, path);
            //    }
            //    return result;
            //    #endregion
            //}

            // Pierwszy argument (jeśli jest podany) określa przeszukiwany katalog.
            //Rekurencja 191
            // Domyślnie używany jest katalog bieżący.
            #endregion
            #region Metody Rekurencyjne silnie
            //public static void Main(string[] args)
            //    {
            //        int totalLineCount = 0;
            //        string directory;
            //        if (args.Length > 0)
            //        {
            //            directory = args[0];
            //        }
            //        else
            //        {
            //            directory = Directory.GetCurrentDirectory();
            //        }
            //        totalLineCount = DirectoryCountLines(directory);
            //        System.Console.WriteLine(totalLineCount);
            //    }
            //    static int DirectoryCountLines(string directory)
            //    {
            //        int lineCount = 0;
            //        foreach (string file in
            //         Directory.GetFiles(directory, ".cs"))
            //        {
            //            lineCount += CountLines(file);
            //        }
            //        foreach (string subdirectory in
            //         Directory.GetDirectories(directory))
            //        {
            //            lineCount += DirectoryCountLines(subdirectory);
            //        }
            //        return lineCount;
            //    }
            //    private static int CountLines(string file)
            //    {
            //        string line;
            //        int lineCount = 0;
            //        FileStream stream =new FileStream(file, FileMode.Open); 
            //   StreamReader reader = new StreamReader(stream);
            //        line = reader.ReadLine();
            //        while (line != null)
            //        {
            //            if (line.Trim() != "")
            //            {
            //                lineCount++;
            //            }
            //            line = reader.ReadLine();
            //        }
            //        reader.Close(); // Automatycznie zamyka strumień.
            //        return lineCount;
            //    }
            //static void Main(string[] args)
            //{
            //    Silnia sl = new Silnia();
            //    Console.Write("Silnia liczby 6 to : {0}", sl.ObliczSilnie(6));
            //    Console.ReadKey();
            //    // Wynik działania programu
            //    // Silnia liczby 6 to : 720
            //}
            //class Silnia
            //{
            //    public int ObliczSilnie(int liczba)
            //    {
            //        int wynik;
            //        if (liczba == 1)
            //            return 1;
            //        else
            //        {
            //            wynik = ObliczSilnie(liczba - 1) * liczba;
            //            return wynik;
            //        }
            //    }
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Program obliczajacy silnie :)");
            //    CountSilnia();
            //    Console.ReadLine();
            //}

            //public static void CountSilnia()
            //{
            //    Console.WriteLine("Podaj liczbe do silni");
            //    int liczba = int.Parse(Console.ReadLine());
            //    int silnia = 1 ;
            //    for (int n = 1; n<=liczba; n++)
            //    {
            //        silnia = silnia * n;
            //        Console.WriteLine("{0,2}! = {1}", n,silnia);
            //    }

            //}
            #endregion
            // #region Przeciazenie metod
            // public static void Main(string[] args)
            // {
            //     int totalLineCount;
            //     if (args.Length > 1)
            //     {
            //         totalLineCount =
            //         DirectoryCountLines(args[0], args[1]);
            //     }

            //     if (args.Length > 0)
            //     {
            //         totalLineCount = DirectoryCountLines(args[0]);
            //     }
            //     else
            //     {
            //         totalLineCount = DirectoryCountLines();
            //     }
            //     System.Console.WriteLine(totalLineCount);
            // }
            // static int DirectoryCountLines()
            // {
            //     return DirectoryCountLines(
            //     Directory.GetCurrentDirectory());
            // }
            // static int DirectoryCountLines(string directory)
            // {
            //     return DirectoryCountLines(directory, "*.cs");
            // }
            // static int DirectoryCountLines(
            // string directory, string extension)
            // {
            //     int lineCount = 0;
            //     foreach (string file in
            //      Directory.GetFiles(directory, extension))
            //     {
            //         lineCount += CountLines(file);
            //     }
            //     foreach (string subdirectory in
            //      Directory.GetDirectories(directory))
            //     {
            //         lineCount += DirectoryCountLines(subdirectory);
            //     }
            //     return lineCount;
            // }
            // private static int CountLines(string file)
            // {
            //     int lineCount = 0;
            //     string line;
            //     FileStream stream =
            //      new FileStream(file, FileMode.Open); 
            //StreamReader reader = new StreamReader(stream);
            //     line = reader.ReadLine();
            //     while (line != null)
            //     {
            //         if (line.Trim() != "")
            //         {
            //             lineCount++;

            //             //     4 Ten kod można poprawić za pomocą instrukcji using, którą jednak pominięto, ponieważ nie została
            //             //ona jeszcze opisana.
            //             //Parametry opcjonalne 195
            //         }
            //         line = reader.ReadLine();
            //     }
            //     reader.Close(); // Automatycznie zamyka strumień.
            //     return lineCount;
            //     #endregion
            //#region parametry opcjonalne i przeciazenie

            //public static void Main(string[] args)
            //{
            //    Wyswietl();
            //    Wyswietl("Krzys", "Wierzbicki", "judasz");

            //  }

            //private static void Wyswietl(string a= "Karol " , string b  = "Kaim")
            //{
            //    Console.WriteLine("Witaj ! {0}{1}",a ,b);
            //}
            //private static void Wyswietl(string a , string b,string c)
            //{
            //    Console.WriteLine("Witaj ! {0}{1}{2}", a, b,c);
            //}


            #region Obsługa błędów
            //static void Main() kod z błedem
            //{ 
            //    string firstName;
            //    string ageText;
            //    int age;
            //    Console.WriteLine("Hej, ty!");
            //    Console.WriteLine("wprowadz imie");
            //    firstName = Console.ReadLine();
            //    Console.WriteLine("wprowadz wiek");
            //    ageText = Console.ReadLine();
            //    Console.WriteLine("wprowadz wiek");
            //    age = int.Parse(ageText);


            //    Console.WriteLine($"hej {firstName} twoj wiek w miesiacach to {age*12}");

            // }
            //static int Main()
            //{
            //    string firstName;
            //    string ageText;
            //    int age;
            //    int result = 0;
            //    Console.WriteLine("Hej, ty!");
            //    Console.WriteLine("wprowadz imie");
            //    firstName = Console.ReadLine();
            //    Console.WriteLine("wprowadz wiek");
            //    ageText = Console.ReadLine();
            //    Console.WriteLine("wprowadz wiek");
            //    try
            //    {
            //        age = int.Parse(ageText);
            //        Console.WriteLine(
            //        $"Hej, {firstName}! Twój wiek w miesiącach to { age * 12 }.");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine(
            //        $"Wprowadzony wiek, {ageText}, nie jest prawidłowy.");
            //        result = 1;
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(
            //        $"Nieoczekiwany błąd: {exception.Message}");
            //        result = 1;
            //    }
            //    finally
            //    {
            //        Console.WriteLine($"Żegnaj, {firstName}!");
            //    }
            //    return result;
            //} 
            // TRY + FINALY TRY + FINALY TRY + FINALYTRY + FINALY
            //static int Main()
            //{
            //    string firstName;
            //    string ageText;
            //    int age;
            //    int result = 0;
            //    Console.Write("Wprowadź imię: ");
            //    firstName = Console.ReadLine();
            //    Console.Write("Wprowadź wiek: ");
            //    ageText = Console.ReadLine();
            //    try
            //    {
            //        age = int.Parse(ageText);
            //        Console.WriteLine(
            //        $"Hej, {firstName}! Twój wiek w miesiącach to { age * 12 }.");
            //    }
            //    finally
            //    {
            //        Console.WriteLine($"Żegnaj, { firstName }!");
            //    }
            //    return result;

            //THROW THORW THROW THORW THROW THORWTHROW THORWTHROW THORWTHROW THORW
            //public static void Main()
            //{
            //    try
            //    {
            //        Console.WriteLine("rozpoczęcie wykonania kodu");
            //        Console.WriteLine("Zgloszenie wyjatku");
            //        throw new Exception("Dowony wyjątek");
            //        Console.WriteLine("Koniec wykonania kodu");

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Zgloszono wyjatek");
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine($"nieoczekiwany blad : {exception.Message}");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("nieoczekiwany blad : ");
            //    }
            //    Console.WriteLine("zamknij program");
            //}

            //public static void Main()
            //{
            //    string firstName;
            //    string ageText;
            //    int age;
            //    Console.Write("Wprowadź imię: ");
            //    firstName = Console.ReadLine();
            //    Console.Write("Wprowadź wiek: ");
            //    ageText = Console.ReadLine();
            //    if (int.TryParse(ageText, out age))
            //    {
            //        Console.WriteLine(
            //        $"Hej, { firstName }! "
            //        + $"Twój wiek w miesiącach to { age * 12 }.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(
            //        $"Wprowadzony wiek, { ageText }, nie jest prawidłowy.");
            //    }
            //}
            #endregion
        }
    }
}
 



