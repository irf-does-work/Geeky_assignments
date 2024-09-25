using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class First20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 20 integers:");
            int count = 1;
            for (; count <= 20; count++) 
            {
                Console.WriteLine(count);
            }

        }
    }
}
