using System;
using System.Linq;

class RotationAndSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int k = int.Parse(Console.ReadLine());
        int n = arr.Length;
        int[] sum = new int[n];

        int[] rotated = new int[n];
        Array.Copy(arr, rotated, n); 

        
        for (int r = 0; r < k; r++)
        {
            int lastElement = rotated[n - 1];

            
            for (int i = n - 1; i > 0; i--)
            {
                rotated[i] = rotated[i - 1];
            }
            rotated[0] = lastElement;

           
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
        }

        
        Console.WriteLine(string.Join(" ", sum));
    }
}