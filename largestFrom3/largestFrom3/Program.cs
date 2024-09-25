using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestFrom3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3,max;
            Console.WriteLine("Enter the 3 numbers to be compared: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());   
            num3 = int.Parse(Console.ReadLine());
            max = num1;
            
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
  
            Console.WriteLine("The largest number is: " +max);
            Console.ReadLine();
        }
    }
}
