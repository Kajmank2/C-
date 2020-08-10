using System;

namespace Nauka1Podstawy
{
    class Program
    {
        static void Main(string[] args) {
            //string option;
            //option = "/321help";
            ////...
            //// Porównanie z uwzględnianiem wielkości liter.
            //int result = string.Compare(option, "/help");
            //System.Console.WriteLine(result);
            //Console.ReadLine();
            //Metody Stringi

            //string lastName;
            //lastName = "Dr.Kaim";
            //bool isPhd = lastName.EndsWith("Ph.D.");
            //bool isDr = lastName.StartsWith("Dr.");
            //Console.WriteLine(isDr);
            //Console.ReadLine();

            //string severity = "ostrzeżenie";
            //// Wyświetla zawartość zmiennej severity wielkimi literami

            //System.Console.WriteLine(severity.ToUpper());

            //string palindrome; liczenie znakow
            //System.Console.Write("Wprowadź palindrom: ");
            //palindrome = System.Console.ReadLine();
            //System.Console.WriteLine(
            // $"Liczba znaków w palindromie {palindrome} to"
            // + $" {palindrome.Length}.");

            //           var patent1 =new //Definiowanie podwojnych stringow
            //{Title = "Soczewki dwuogniskowe",YearOfPublication = "1784"};
            //           var patent2 =new
            //            { Title = "Fonograf",YearOfPublication = "1877"};
            //           System.Console.WriteLine(
            //            $"{ patent1.Title } ({ patent1.YearOfPublication })");
            //           System.Console.WriteLine(
            //            $"{ patent2.Title } ({ patent2.YearOfPublication })");

            //zamiana wartosci na stringi i odwrotnie

            //string text = "921323";
            //double liczba = Double.Parse(text);
            ////Console.WriteLine(text);

            //bool bolean = true;
            //string text1 = bolean.ToString();
            //Console.WriteLine(text1);

            //TryParse
            //double number;
            //string input;
            //System.Console.Write("Wprowadź liczbę: ");
            //input = System.Console.ReadLine();
            //if (double.TryParse(input, out number))
            //{
            //}

            //else
            //{
            //    System.Console.WriteLine(
            //    "Wprowadzony tekst nie jest poprawną liczbą.");
            //}
            //tablice

            //           string[] languages = new string[]{
            //"C#", "COBOL", "Java",
            //"C++", "Visual Basic", "Pascal",
            //"Fortran", "Lisp", "J#"};
            //           System.Array.Sort(languages);
            //           string searchString = "COBOL";
            //           int index = System.Array.BinarySearch(
            //           languages, searchString);
            //           System.Console.WriteLine(
            //            "Język przyszłości, "
            //            + $"{ searchString }, jest dostępny pod indeksem { index }.");
            //           System.Console.WriteLine();
            //           System.Console.WriteLine(
            //            $"{ "Pierwszy element",-20 }\t{ "Ostatni element",-20 }");
            //           System.Console.WriteLine(
            //            $"{ "----------------",-20 }\t{ "----------------",-20 }");
            //           System.Console.WriteLine(
            //            $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20}");
            //          // System.Array.Reverse(languages);
            //           //System.Console.WriteLine(
            //           // $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20}");
            //           // Zauważ, że poniższa instrukcja nie usuwa elementów z tablicy.
            //           // Zamiast tego do wszystkich elementów przypisywana jest wartość domyślna.
            //           System.Array.Clear(languages, 0, languages.Length);
            //           //System.Console.WriteLine(
            //           // $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20}");
            //           System.Console.WriteLine(
            //            $"Po wywołaniu Clear wielkość tablicy to: { languages.Length }");

            //zamiana lancuchu w tablice
            string reverse, palindrome;
            char[] temp;
            System.Console.Write("Wprowadź palindrom: ");
            palindrome = System.Console.ReadLine();
            // Usuwanie odstępów i przekształcanie liter na małe
            reverse = palindrome.Replace(" ", "");
            reverse = reverse.ToLower();
            // Przekształcanie w tablicę
            temp = reverse.ToCharArray();
            // Odwracanie kolejności elementów tablicy
            System.Array.Reverse(temp);
            Console.WriteLine(temp);
            // Przekształcanie tablicy z powrotem w łańcuch znaków i
            // sprawdzanie, czy odwrócony łańcuch jest identyczny z pierwotnym.
            if (reverse == new string(temp))
            {
                System.Console.WriteLine(
                $"\"{palindrome}\" jest palindromem.");
            }
            else
            {
                System.Console.WriteLine(
                $"\"{palindrome}\" NIE jest palindromem.");
            }
        }
        
    }
}
            
        
    
    

