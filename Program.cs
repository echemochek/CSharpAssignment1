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

            //Question 2:
            Console.WriteLine("Q2 : Enter the string to check for pangram:");
            string s1 = Console.ReadLine();
            bool flag = CheckIfPangram(s1);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            //Question 3:
            int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 9 } };
            int Wealth = MaximumWealth(arr);

            Console.WriteLine("Q3:");
            Console.WriteLine("Richest person has a wealth of {0}", Wealth);

            //Question 4:
            string jewels = "z";
            string stones = "ZZ";
            Console.WriteLine("Q4:");
            int num = NumJewelsInStones(jewels, stones);
            Console.WriteLine("the number of stones you have that are also jewels are {0}:", num);
        }

        private static bool HalvesAreAlike(string s)
        {
            // declare the string of vowels both uppercase and lowercase to cater for both scenarios
            string vowels = "aeiouAEIOU";

            // initialize a to count vowels in first half
            // b to count vowels in second half
            // mid to define the middle of the string
            int a = 0, b = 0, mid = s.Length/2;
            try
            {
                // loop through indices of the halves of given string
                for (int i = 0; i < mid; i++)
                {
                    // looping through elements of the first half and adding to a if element is vowel
                    if (vowels.Contains(s[i].ToString()))
                    {
                        a += 1;
                    }
                    // looping through elements of the second half and adding to b if element is vowel
                    if (vowels.Contains(s[mid + i].ToString()))
                    {
                        b += 1;
                    }
                }
                // compare the value of a & b
                // if equal, the halves have same number of vowels
                return a == b;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private static bool CheckIfPangram(string s)
        {
            // declare the string of alphabets, length of the alphabets, and length of the input sentence
            string alphabets = "abcdefghijklmnopqrstuvwxyz";

            int a = alphabets.Length;
            int b = s.Length;
            int num = 0;
            try
            {
                // loop through each letter of the alphabet
                for (int i = 0; i < a; i++)
                {
                    // loop through each letter of the input sentence
                    for (int j = 0; j < b; j++)
                    {
                        // compare alphabet letter with letter appearing in sentence
                        // if they match, add 1 to the variable num
                        if (alphabets[i] == s[j])
                        {
                            num += 1;
                            // exit the loop to avoid counting other appearence of same letter
                            break;
                        }
                    }
                }
                // there are 26 letters in the alphabet
                // if num = 26, it means all letters of the alphabet appear in given sentence
                return num == 26;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static int MaximumWealth(int[,] accounts)
        {
            int rows = accounts.GetLength(0);
            int cols = accounts.GetLength(1);

            int[] customerWealth = new int[rows];
            int i, j;
            try
            {
                for (i = 0; i < rows; i++)
                {
                    customerWealth[i] = 0;
                    for (j = 0; j < cols; j++)
                        customerWealth[i] = customerWealth[i] + accounts[i, j];
                }
                Array.Sort(customerWealth);
                return customerWealth[customerWealth.Length - 1];
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int NumJewelsInStones(string jewels, string stones)
        {
            int total = 0;
            try
            {
                // loop through each individual stone
                for (int i = 0; i < stones.Length; i++)
                {
                    if (jewels.Contains(stones[i]))
                    {
                        total += 1;
                    }
                }
                return total;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

    }
}