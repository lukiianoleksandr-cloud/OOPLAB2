using System;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int difference = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == difference)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}