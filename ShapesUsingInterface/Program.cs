using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static ShapesUsingInterface.Rectangle;


namespace ShapesUsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;
            Circle circle1 = new Circle(10);
            result = circle1.CalculateArea();
            Console.WriteLine("Area of Circle= " +result);
            result = circle1.CalculatePerimeter();
            Console.WriteLine("Perimeter of Circle= " + result);

            Rectangle rectangle1 = new Rectangle(2, 5);
            result = rectangle1.CalculateArea();
            Console.WriteLine("Area of Rectangle= " + result);
            result = rectangle1.CalculatePerimeter();
            Console.WriteLine("Perimeter of Rectangle= " + result);

            Triangle triangle1 = new Triangle(3,4,5,6,3);
            result = triangle1.CalculateArea();
            Console.WriteLine("Area of Triangle= " + result);
            result = triangle1.CalculatePerimeter();
            Console.WriteLine("Perimeter of Triangle= " + result);

        }
    }
    public interface Ishape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }


    public class Circle : Ishape
    {
        double rad;
        public Circle(double rad)
        {
            this.rad = rad;
        }

        public double CalculateArea()
        {
            return 3.141 * rad * rad;
        }

        public double CalculatePerimeter()
        {
            return 2 * 3.141 * rad;
        }
    }

    public class Rectangle : Ishape
    {
        double length, breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            return length * breadth;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }

    }
        public class Triangle : Ishape
        {
            double tbase, theight, side1, side2, side3;
        public Triangle(double tbase,double theight,double side1,double side2,double side3)
        {
            this.tbase = tbase;
            this.theight = theight; 
            this.side1 = side1;                
            this.side2 = side2;
            this.side3 = side3;
        }
        public double CalculateArea()
        {
                return 0.5 * tbase * theight;
            }

            public double CalculatePerimeter()
            {
                return side1 + side2 + side3;

            }
        }
    }
