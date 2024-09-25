using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num;
                Console.WriteLine("Enter the number to check if prime: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 1)
                {
                    Console.WriteLine("The number is NOT a Prime");
                    Console.ReadLine();
                    return;
                }

                else if (num == 2)
                {
                    Console.WriteLine("The number is a Prime");
                    Console.ReadLine();
                    return;
                }

                for (int i = 2;i <= (num/2); i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("The number is NOT a Prime");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                Console.WriteLine("The number is a Prime");
                Console.ReadLine();
            
        }
    }
}
