using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsOperations2
{
    public class ArithmeticOperation
    {
        double result;
        public double Add(double num1, double num2)
        {
            result = num1 + num2;
            return result;
        }

        public double Sub(double num1, double num2)
        {
            result = num1 - num2;
            return result;
        }
    }
}
