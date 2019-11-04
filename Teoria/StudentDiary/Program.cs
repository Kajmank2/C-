using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void GiveName(Diary diary)
        {
            diary.Name = "dzienniczek Marcina";
        }
        static void Main(string[] args)
        {
            #region
            //Diary diary = new Diary();

            //diary.AddRatings(5);
            //diary.AddRatings(6);
            //diary.AddRatings(4);
            //diary.GiveMaxRating();
            //diary.GiveMinRating();
            //diary.CalculateAvarage();
            //Console.WriteLine(diary.CalculateAvarage());

            //float avg = diary.CalculateAvarage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();
            //Console.WriteLine("{0},{1},{2}", avg, max, min);

            //DiaryStatistics stats = diary.ComputerStatistic();
            //Console.WriteLine("Srednia wartosc : " + stats.AverageGrade);
            ////for (; ; )
            ////{
            ////    Console.WriteLine("Podaj ocene z zakresu 1-10");

            ////    float rating;
            ////    bool result = float.TryParse(Console.ReadLine(), out rating); // sprawdzaie
            ////    diary.AddRatings(rating);

            ////    if (rating == 11)
            ////    {
            ////        break;
            ////    }
            ////    if (result)
            ////    {
            ////        if (rating > 0 && rating <= 10)
            ////        {
            ////            diary.AddRatings(rating);
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("podaj liczbe z poprawnego zakresu");
            ////        }
            ////    }

            ////}
            ////Console.WriteLine("Srednia ocen to : " + diary.CalculateAvarage());
            ////Console.WriteLine("Max OCena to : " + diary.GiveMaxRating());
            #endregion dzienniczek
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(d1);

            Console.WriteLine(d1);
            int x1 = 4;
            int x2 = 1;

            x1 = 100;
            Console.WriteLine(x2);
            Console.ReadKey();
        }
    }
}
