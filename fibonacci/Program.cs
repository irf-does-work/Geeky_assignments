using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit, num1=0, num2=1, next, temp;
            Console.WriteLine("Enter the no. of terms: ");
            limit = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            next = num1 + num2;
            for(int i=3; i<=limit; i++)
            {
                Console.WriteLine(next);
                num1 = num2;
                num2 = next;
                next = num1+num2;
            }
            
        }
    }
}
