using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len,flag=0;
            string str;
            Console.WriteLine("Enter the word to check for palindrome");
            str=Console.ReadLine();
            len = str.Length;

            for (int i=0; i<len/2; i++)
            {
                if (str[i] != str[len - i - 1]) 
                {
                    Console.WriteLine("Not a palindrome");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Given string is a palindrome");
            }
        }
    }
}
