using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Queue<int> queue = new Queue<int>();
        Queue<string> output = new Queue<string>();
        int q = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            string[] line = Console.ReadLine().Split();
            int type = Convert.ToInt32(line[0]);

            if (type == 1)
            {
                queue.Enqueue(Convert.ToInt32(line[1]));
            }
            else if (type == 2)
            {
                queue.Dequeue();
            }
            else if (type == 3)
            {
                output.Enqueue(queue.Count == 0 ? "" : queue.Peek().ToString());
            }
        }

        while(output.Count != 0)
        {
            Console.WriteLine(output.Dequeue());
        }
    }
}