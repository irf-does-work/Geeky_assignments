using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("ENTER A CHARACTER");
            c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'c': Console.WriteLine("Cricket"); break;
                case 'f': Console.WriteLine("Football"); break;
                case 'h': Console.WriteLine("Hockey"); break;
                case 't': Console.WriteLine("Tennis"); break;
                case 'b': Console.WriteLine("Basketball"); break;
                default: Console.WriteLine("Invalid input, please try again"); break;
            }
        }
    }
}
