using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsOperations2;

namespace CalcUsingClassLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1,input2,result;
            bool boolResult;
            ArithmeticOperation arithmetic1 = new ArithmeticOperation();
            Console.WriteLine("Enter two numbers: ");
            input1 = int.Parse(Console.ReadLine());
            input2 = int.Parse(Console.ReadLine());


            result = arithmetic1.Add(input1,input2);
            Console.WriteLine("Sum = " +result);

            result = arithmetic1.Sub(input1,input2);
            Console.WriteLine("Difference = " + result);

            RelationalOperation relational1 = new RelationalOperation();
            boolResult = relational1.GreaterThan(input1, input2);
            Console.WriteLine(input1 + " is greater than " + input2 + " : " +boolResult);

            boolResult = relational1.Equal(input1, input2);
            Console.WriteLine(input1 + " is Equal to " + input2 + " : " + boolResult);

        }
    }
}
