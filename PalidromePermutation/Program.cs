using System;
using System.Collections.Generic;

namespace PalidromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ataoata";
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach(var c in s)
            {
                if (letters.ContainsKey(c))
                {
                    letters[c]++;
                }
                else
                {
                    letters[c] = 1;
                }
            }

            bool isPalindrome = true;
            bool containsOdd = false;

            if (s.Length % 2 == 1)
            {
                containsOdd = true;
            }

            foreach(var element in letters)
            {
                if (element.Value % 2 == 1)
                {
                    if (containsOdd == true)
                    {
                        containsOdd = false;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");

            }
        }
    }
}
