using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the string:");
            string s = Console.ReadLine();
            bool pos = HalvesAreAlike(s);
            if (pos)
            {
                Console.WriteLine("Both Halfs of the string are alike");
            }
            else
            {
                Console.WriteLine("Both Halfs of the string are not alike");
            }

            Console.WriteLine();

        }
        
        private static bool HalvesAreAlike(string s)
        {
            string vowels = "aeiouAEIOU";
            int a = 0, b = 0, mid = vowels.Length/2;
            try
            {
                // write your code here
                for (int i = 0; i <= s.Length / 2; i++)
                {
                    if (vowels.Contains(s[i])){
                    a += 1;
                    }
                    if (vowels.Contains(s[-i-1])) {
                    b += 1;
                    }
                }
                return a==b;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}