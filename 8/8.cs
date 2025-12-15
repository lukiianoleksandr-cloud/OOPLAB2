using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxCount = 0;
        int mostFrequentNumber = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            int currentCount = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    currentCount++;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                mostFrequentNumber = arr[i];
            }
        }

        Console.WriteLine(mostFrequentNumber);
    }
}