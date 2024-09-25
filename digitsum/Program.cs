using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter the number to calculate Digit Sum: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
