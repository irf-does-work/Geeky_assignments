using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            double num1, num2, result=9999;
            int operation;
            Console.WriteLine("Enter any two numbers");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Select an Operation:\n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
            operation = int.Parse(Console.ReadLine());
            Calc c1= new Calc();
            switch (operation)
            {
                case 1: result = c1.Add(num1, num2); break;
                case 2: result = c1.Sub(num1, num2); break;
                case 3: result = c1.Mul(num1, num2); break;
                case 4: result = c1.Div(num1, num2); break;
                default: Console.WriteLine("An ERROR occured"); break;
            }
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

    }


    public class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
    }
}
