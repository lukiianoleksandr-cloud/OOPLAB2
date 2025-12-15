using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = arr.Length / 4;
        int n = arr.Length;
        int[] row1 = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            row1[i] = arr[k - 1 - i];
        }

        for (int i = 0; i < k; i++)
        {
            row1[k + i] = arr[n - 1 - i];
        }

        int[] row2 = new int[2 * k];
        Array.Copy(arr, k, row2, 0, 2 * k);

        int[] sum = new int[2 * k];
        for (int i = 0; i < 2 * k; i++)
        {
            sum[i] = row1[i] + row2[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}