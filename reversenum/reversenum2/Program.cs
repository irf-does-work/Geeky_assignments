using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversenum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,reverse=0;
            Console.WriteLine("Enter the number to be reversed: ");
            num = int.Parse(Console.ReadLine());
            while(num > 0)
            {
                reverse = (reverse * 10) + num % 10;
                num = num/10;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
