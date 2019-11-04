using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>(); // nie ma znaczenia gdzie jest zainicjonowana
        }
        //Stan
        List<float> ratings = new List<float>();
        public string Name { get; set; }

        //Zachowania
        public void AddRatings(float rating)
        {
            ratings.Add(rating);
        }
        public float CalculateAvarage()
        {
            float sum = 0;
            float avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();
           
            return avg;
        }

        internal DiaryStatistics ComputerStatistic()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }

        public float GiveMaxRating()
        {
           return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
