using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_lt_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers < 50 are: ");
            int count = 1;
            while (count < 50)
            {
                Console.WriteLine(count);
                count+=2;
            }
            Console.ReadLine();

        }
    }
}
