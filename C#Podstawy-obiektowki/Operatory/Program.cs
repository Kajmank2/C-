using System;

namespace Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numerator;
            //int denominator;
            //int quotient;
            //int remainder;
            //System.Console.Write("Wprowadź licznik: ");
            //numerator = int.Parse(System.Console.ReadLine());
            //System.Console.Write("Wprowadź mianownik: ");
            //denominator = int.Parse(System.Console.ReadLine());
            //quotient = numerator / denominator;
            //remainder = numerator % denominator;
            //System.Console.WriteLine(
            // $"{numerator} / {denominator} = {quotient}, reszta {remainder}");
            //Inkrementacje
            //int count = 123;
            //int result;
            //result = count++;
            //System.Console.WriteLine(
            // $"result = {result} i count = {count}");

            //int x = 123;
            //// Wyświetla 123, 124, 125.
            //System.Console.WriteLine($"{x++}, {x++}, {x}");
            //// Teraz x zawiera wartość 125.
            // Wyświetla 126, 127, 127.
            //System.Console.WriteLine($"{++x}, {++x}, {x}");
            //// Teraz x zawiera wartość 127.
            // INSTRUKCJE ++++++++++++++++++++++++
            //IFFFFFFFFFF
            //            string input;
            //            System.Console.Write(
            // "1 – Gra przeciwko komputerowi\n" +
            // "2 – Gra przeciwko innemu graczowi\n" +
            // "Wybierz:"
            //);
            //            input = System.Console.ReadLine();
            //            if (input == "1")
            //                // Użytkownik wybrał grę przeciwko komputerowi.
            //                System.Console.WriteLine(
            //                "Wybrano grę przeciwko komputerowi.");
            //            else
            //                // Domyślnie wybierana jest gra dla 2 graczy (nawet jeśli użytkownik nie wpisał 2).
            //                System.Console.WriteLine(
            //                "Wybrano grę przeciwko drugiej osobie.");
            //double radius; // Deklaracja zmiennej przechowującej promień.
            //double area; // Deklaracja zmiennej przechowującej powierzchnię.
            //System.Console.Write("Wprowadź promień koła: ");
            //// Instrukcja double.Parse przekształca wartość zwróconą
            //// przez polecenie ReadLine() na typ double.
            //radius = double.Parse(System.Console.ReadLine());
            //if (radius >= 0)
            //{
            //    // Obliczanie powierzchni koła.
            //    area = Math.PI * radius * radius;
            //    System.Console.WriteLine(
            //    $"Powierzchnia koła wynosi: {area : 0.00}");
            //}
            //else
            //{
            //    System.Console.WriteLine(
            //    $"{ radius } nie jest poprawną wartością promienia.");
            //}

            //DOOOOOOOOOOOOODDDDDDDDDDDDO
            //decimal current;
            //decimal previous;
            //decimal temp;
            //decimal input;
            //System.Console.Write("Wprowadź dodatnią liczbę całkowitą:");
            //// Instrukcja decimal.Parse przekształca wartość pobraną przez metodę ReadLine na liczbę dziesiętną.
            //input = decimal.Parse(System.Console.ReadLine());
            //// Inicjowanie zmiennych current i previous wartością 1. Są to dwie
            //// pierwsze liczby z ciągu Fibonacciego.
            //current = previous = 1;
            //// Dopóki obecna liczba Fibonacciego w ciągu ma
            //// wartość mniejszą niż liczba podana przez użytkownika.
            //while (current <= input)
            //{
            //    temp = current;
            //    current = previous + current;
            //    previous = temp; // Wykonywane nawet w sytuacji, gdy poprzednia
            //                     // instrukcja spowodowała, że zmienna current ma wartość większą niż zmienna input.
            //}
            //System.Console.WriteLine(
            //$"Następna liczba Fibonacciego to { current }");

            //for
            //const int size = 64;
            //ulong value;
            //char bit;
            //System.Console.Write("Wprowadź liczbę całkowitą: ");
            //// Używanie instrukcji long.Parse(), aby zapewnić obsługę liczb ujemnych.
            //// Kod bez sprawdzania przypisuje wartość do zmiennej typu ulong.
            //value = (ulong)long.Parse(System.Console.ReadLine());
            //// Ustawianie początkowej maski na 100.
            //ulong mask = 1UL << size - 1;
            //for (int count = 0; count < size; count++)
            //{
            //    bit = ((mask & value) > 0) ? '1' : '0';
            //    System.Console.Write(bit);
            //    // Przesunięcie maski o jedną pozycję w prawo.
            //    mask >>= 1;
            //}
            //for eahc
            // ---+---+---
            //            char[] cells = {
            // '1', 'X', '3', '4', '5', '6', '7', '8', '9'
            //};
            //            System.Console.Write(
            //             "Możliwe posunięcia to: ");
            //            foreach (char cell in cells)
            //            {
            //                if (cell != 'O' && cell != 'X')
            //                {
            //                    System.Console.Write($"{ cell } "); // jezeli wpiszemy x to bedzie niemozliwe posuniecie
            //                }

            //            }
            //switch //switch //switch //switch//switch//switchv
            System.Console.WriteLine("Write your code at here");
            int a, b, sum;
            Console.WriteLine("Podaj a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b ");
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine($"twoja suma {sum}");
        }
    }
}
    
