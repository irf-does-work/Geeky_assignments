using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter the amount: ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Tax to be paid: ");
            if (amount < 10000) 
            {
                Console.WriteLine("5%");
            }
            else if (amount < 15000)
            {
                Console.WriteLine("7.5%");
            }
            else if (amount < 20000)
            {
                Console.WriteLine("10%");
            }
            else if (amount < 25000)
            {
                Console.WriteLine("12.5%");
            }
            else 
            {
                Console.WriteLine("15%");
            }
        }
    }
}
