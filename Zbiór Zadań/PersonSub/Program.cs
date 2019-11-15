using System;

namespace PersonSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Karol", "Koszykowa2");
            Person personik = new Student("karol", "Koszykwoa", "C#", 1992, 12.00);
            Console.WriteLine(person);
            Console.WriteLine(personik);
            Console.WriteLine("Hello World!");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Addres { get; set; }
        public Person(string name , string adres)
        {
            this.Name = name;
            this.Addres = adres;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Addres;
        }
        public string SetAddres(string adres)
        {
            this.Addres = adres;
            return adres;
        }
        public override string ToString()
        {
            return "" + this.Name + "" + this.Addres;
        }
    }
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }
        public Student(string name , string adress , string program, int year , double fee) : base(name,adress)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Addres + " " + this.Program + " " + this.Year + " " + this.Fee + " ";
        }
    }
}
