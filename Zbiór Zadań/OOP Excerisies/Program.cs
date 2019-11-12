using System;

namespace OOP_Excerisies
{
    class OwnException : Exception
    {
        public OwnException(string msg) : base(msg)
        {
            msg = "I am here for your fallout";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyTime mt = new MyTime(13,22,59);
            MyTime mt3 = new MyTime(33, 14, 66);
            MyTime mt2 = new MyTime(12, 66, 62);
            Console.WriteLine(mt);
            mt.getHour();
            Console.WriteLine(mt.nextSecond());
            Console.WriteLine(mt);
            Console.WriteLine(mt.previousSecond());
            Console.WriteLine(mt);
            //Console.WriteLine("Hours: {0}, Minute: {1} , Second: {2}" ,mt2.Hour , mt2.Minute , mt2.Second);
            //Console.WriteLine(mt + mt2);
            //Console.ReadKey();
        }
    }
    class MyTime
    {
        public int Hour { get; private set; }
        private int _minute;
        public int Minute
        {
            get
            { return _minute; }
            set
            {
                if (_minute <= 0)
                    this._minute = 0;
                else if(value >= 60)
                {
                    int hourInMinutes = value / 60;
                    Hour += hourInMinutes;
                    this._minute = (value - hourInMinutes * 60);
                }
                this._minute = value;
            }
        }
        private int _second;
        public int Second
        {
            get
            { return _second; }
            set
            {
                if (_second <= 0)
                    this._second = 0;
                else if (value >= 60)
                {
                    int minutesInSecond = value / 60;
                    Minute += minutesInSecond;
                    this._second = (value - minutesInSecond * 60);
                }
                this._second = value;
            }

        }
        public MyTime(MyTime mt)
        {
            this.Hour = mt.Hour;
            this.Minute = mt.Minute;
            this.Second = mt.Second;
        }
        public MyTime()
        {
            Hour = 2;
            Minute = 34;
            Second = 50;

        }
        public MyTime(int hour , int minute , int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
            try
            {
                if (Hour > 70)
                {
                    throw new OwnException("Godzin nie moze byc wiecej niż 60");
                }
                if (Minute > 70)
                {
                    throw new OwnException("Minut nie moze byc wiecej niż 60");
                }
                if (Second > 70)
                {
                    throw new OwnException("Sekund nie moze byc wiecej niż 60");
                }
            }
            catch (Exception )
            {
                throw;
            }
        }
        public int Minuteczka(int minute)
        {
            int multiminute;
            multiminute = minute * minute;
            return multiminute;
        }
        public static MyTime operator +(MyTime L, MyTime P) // jezeli damy + automatycznie sie ona wykonuje
        {
            int tmpHour = L.Hour + P.Hour;
            int tmpMinute = (L.Minute + P.Minute);
            int minutywGodzinach = tmpMinute / 60;
            tmpHour += minutywGodzinach;
            tmpMinute = tmpMinute - minutywGodzinach * 60;
            int tmpSecond = (L.Second + P.Second);
            int sekundyWMinutach = tmpSecond / 60;
            tmpMinute += sekundyWMinutach;
            tmpSecond = tmpSecond - sekundyWMinutach * 60;
          
            return new MyTime(tmpHour, tmpMinute, tmpSecond); //zwaracamy miejsce w pamieci z wartosciami tymaczasowymi
        }
        public  void getHour()
        {
            Console.WriteLine(Hour);
        }
        public void GetMinute()
        {
            Console.WriteLine(Minute);
        }
        public void GetSecond()
        {
            Console.WriteLine(Second);
        }
        public int SetHour(int hour)
        {
           return this.Hour = hour;
        }
        public int SetMinute(int minute)
        {
            return this.Minute = minute;
        }
        public int SetSecond(int second)
        {
            return this.Second = second;
        }

        public override string ToString()
        {
            return Hour + ":" + Minute + ":" + Second + ":";
        }
        public int nextSecond()
        {
            ++this.Second;          
            if (this.Second <= 0)
                return Second;
            else if (this.Second >= 60)
            {
                int tmpSecond = this.Second / 60;
                Minute += tmpSecond;
                this.Second = (Second - tmpSecond * 60);
            }
            return this.Second;


        }
        public int previousSecond()
        {
            --this.Second;
            if(this.Second >=0)
            return Second;
            else if (this .Second >= 60)
            {
                int tmpSecond = this.Second / 60;
                Minute += tmpSecond;
                this.Second = (this.Second - tmpSecond * 60);
            }
            return this.Second;
        }
    }
}
