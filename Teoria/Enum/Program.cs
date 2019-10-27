using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        public enum TimeofDay
        {
            Morning=0 ,Afternoon=3, Evening // domyslnie eveening bedzie rowny 4 bo to typ wyliczeniowy
        }
        public static string getGreeting(TimeofDay time)
        {
            switch (time)
            {
                case TimeofDay.Morning:
                    return "good morning";
                case TimeofDay.Afternoon:
                    return "good afternoon";
                case TimeofDay.Evening:
                    return "good evening";
                default:
                    return "cos poszlo nie tak"; 
            }
        }
        static void Main(string[] args)
        {
            //  TimeofDay a = TimeofDay.Morning;
            TimeofDay b = (TimeofDay)1;
            Console.WriteLine(getGreeting(b));

            Console.ReadKey();
        }
    }
}
