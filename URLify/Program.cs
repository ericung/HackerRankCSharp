using System;
using System.Collections.Generic;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            String helloWorld = "hello world!";
            String string2 = "world hello!";
            Char[] helloWorldArray = helloWorld.ToCharArray();
            Dictionary<Char, int> dictionary = new Dictionary<Char, int>();
            Boolean isEqual = true;

            foreach (Char c in helloWorldArray)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            foreach (var c in dictionary)
            {
                Console.WriteLine(c.Key + ": " + c.Value);
            }

            foreach (Char c in string2)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]--;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
