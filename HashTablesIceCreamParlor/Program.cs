using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static int indexOf(int[] menu, int value, int excludeThis)
    {
        for (int i = 0; i < menu.Length; i++)
        {
            if (menu[i] == value && i != excludeThis)
            {
                return i;
            }
        }
        return -1;
    }

    public static int[] getIndicesFromValues(int[] menu, int value1, int value2)
    {
        int index1 = indexOf(menu, value1, -1);
        int index2 = indexOf(menu, value2, index1);
        int[] indices = { Math.Min(index1, index2) + 1, Math.Max(index1, index2) + 1};
        return indices;
    }

    static int[] solve(int[] arr, int money)
    {
        // Complete this function
        int[] sortedArr = (int[])arr.Clone();
        Array.Sort(sortedArr);

        for (int i = 0; i < sortedArr.Length; i++)
        {
            int complement = money - sortedArr[i];
            int location = Array.BinarySearch(sortedArr, complement);
            if (location >=0 && location < sortedArr.Length && sortedArr[location] == complement)
            {
                int[] indices = getIndicesFromValues(arr, sortedArr[i], complement);
                return indices;
            }
        }
        return null;
    }

    static void Main(String[] args)
    {
        Queue<int[]> queue = new Queue<int[]>();
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int money = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            queue.Enqueue(solve(arr, money));
        }

        while (queue.Count != 0)
        {
            int[] ans = queue.Dequeue();
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
    }
}
