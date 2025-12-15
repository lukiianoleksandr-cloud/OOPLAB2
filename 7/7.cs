using System;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int bestStart = 0;
        int bestLen = 1;
        int currentStart = 0;
        int currentLen = 1;

        if (arr.Length == 0) return;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                currentLen++;
            }
            else
            {
                currentStart = i;
                currentLen = 1;
            }

            if (currentLen > bestLen)
            {
                bestLen = currentLen;
                bestStart = currentStart;
            }
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}