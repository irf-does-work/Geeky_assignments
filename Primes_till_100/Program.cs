using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_till_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key;
            for (key = 2; key <= 100; key++)
            {
                bool prime=true;

                for (int i = 2; i <= (key / 2); i++)
                {
                    if (key % i == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime) 
                {
                    Console.WriteLine(key);
                }
                
            }
            Console.ReadLine();
        }
    }
}
