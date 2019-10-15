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
            Morning ,Afternoon, Evening
        }
        public static string getGreeting(TimeofDay time)
        {
            switch (time)
            {
                case TimeofDay.Morning:
                    return "good mornink";
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
            TimeofDay a = TimeofDay.Morning;

            Console.ReadKey();
        }
    }
}
