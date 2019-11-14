using System;

namespace OOP_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate md = new MyDate(1996, 15, 28);
            Console.WriteLine(md.Year);
            Console.WriteLine(md.isLeapYear(md.Year));
            md.SetMonth(14);
            Console.WriteLine("Elo elo rok{0} , elo elo miesiąc{1}",md.Year,md.Month);
            Console.WriteLine(md.Day);
            Console.WriteLine(md.Month);
            Console.WriteLine(md);

            DateTime date = DateTime.Now;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
            {
                Console.WriteLine("This is a weekend");
            }
            else
            {
                Console.WriteLine("Poczekaj do weekend");
            }

            var date1 = new DateTime(2008, 5, 31);
            Console.WriteLine(date1.ToString("F"));
            Console.WriteLine(date1);
            Console.WriteLine(day);
        }
    }
    class MyDate
    {
        private int _year;
        public int Year
        {
            get
            {
                if (_year > 2000)
                {
                    Console.WriteLine("Przykro nam twoja Zmienna wykracza poza nasz wykres");
                    return 0;

                }
                else
                    return _year;
            }
            set
            {
                if (_year > 2000)
                    Console.WriteLine("Sorry that is invalid max 2000y");
                else
                    _year = value;
            }
        }
        private int _month;
        public int Month 
        {
            get
            {
                if (_month <= 0)
                    return _month;
                else if (_month > 12)
                {
                    int MiesiaceWLatach = _month / 12;
                    Year += MiesiaceWLatach;
                    this._month = (_month - MiesiaceWLatach * 12);
                }
                return _month;
            }
            set //podczas ustawiania @!
            {
                if (_month <= 0)
                    _month = 0;
                else if(value > 12)
                {
                    int MiesiaceWLatach = value / 12;
                    Year += MiesiaceWLatach;
                   this._month = (value - MiesiaceWLatach * 12);
                } this._month = value;
            }
        }
        public int Day { get; set; }
        public string[] strMonth = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public string[] strDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday" , "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday" , "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday" , "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday" , "Sunday", "Monday", "Tuesday", "Wednesday", "Thurstday", "Friday", "Saturday" };
        public int[] daysInMonths = {31,28,31,30,31,30,31,31,30,31,30,31};
        public MyDate(int year, int month, int day)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public void SetDate(int year, int month, int day)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public int GetYear()
        {
            return this.Year;
        }
        public int GetMonth()
        {
            return this.Month;
        }
        public int GetDay()
        {
            return this.Day;
        }
        public void SetYear(int year)
        {
            this.Year = year;
        }
        public void SetMonth(int month)
        {
            this.Month = month;
        }
        public void SetDay(int day)
        {
            this.Day = day;
        }

       
public override string ToString()
        {
           int n = this.Month;
           int d = this.Day;
           return " " + this.Year +" " + strMonth[n]+ " "+strDays[d];
        }
        public void NextDay(MyDate m)
        {
            m.Day++;
        }
        public void PreviousDay(MyDate mi)
        {
            mi.Day--;
        }
        public bool isLeapYear(int year)
        {
            this.Year = year;
            if ((year % 100) % 4 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
