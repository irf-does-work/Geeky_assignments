using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_square_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum=0 , square = 0;
            Console.WriteLine("Enter the number to calculate Sum of Digit Squares: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                square = num % 10;
                square *= square;
                sum += square ;
                num = num / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
