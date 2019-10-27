using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle(12);
            Shape cy = new Cylinder(12,1);
            Console.WriteLine(c.Area());
            Console.WriteLine(cy.Area());
            Console.ReadKey();
        }
    }
    public class Shape
    {
        public const double PI = 3.14;
        protected double x, y;
        public Shape()
        {

        }
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double Area()
        {
            return x * y;
        }
    }
    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {

        }
        public override double Area()
        {
            return PI * x * x;
        }
    }
    public class Cylinder : Shape
    {
       public Cylinder(double r , double h) : base(r, h)
        {

        }
        public override double Area()
        {
            return 2 * PI * x * x + 2 * x * y;
        }
    }
}
