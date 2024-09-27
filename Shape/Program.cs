using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Circle circle1 = new Circle(5);
                Rectangle rectangle1 = new Rectangle(4, 6);
                Triangle triangle1 = new Triangle(3, 8);

                Console.WriteLine($"Circle Area: {circle1.CalculateArea()}");      
                Console.WriteLine($"Rectangle Area: {rectangle1.CalculateArea()}");
                Console.WriteLine($"Triangle Area: {triangle1.CalculateArea()}");   
            }
        }
    }

    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        double radius;   

        public Circle(double rad)
        {
            radius = rad;
        }

        public override double CalculateArea()
        {
            return 3.141 * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        double length;
        double breadth;

        public Rectangle(double lt, double bt)
        {
            length = lt;
            breadth = bt;
        }

        public override double CalculateArea()
        {
            return length * breadth;
        }
    }

    public class Triangle : Shape
    {
        double tbase;
        double theight;

        public Triangle(double bs, double ht)
        {
            tbase = bs;
            theight = ht;
        }

        public override double CalculateArea()
        {
            return 0.5 * tbase * theight;
        }
    }
}
