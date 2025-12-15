using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = Console.ReadLine().ToCharArray();
        char[] arr2 = Console.ReadLine().ToCharArray();
        int minLength = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine(new string(arr1));
                Console.WriteLine(new string(arr2));
                return;
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine(new string(arr2));
                Console.WriteLine(new string(arr1));
                return;
            }
        }

        if (arr1.Length <= arr2.Length)
        {
            Console.WriteLine(new string(arr1));
            Console.WriteLine(new string(arr2));
        }
        else
        {
            Console.WriteLine(new string(arr2));
            Console.WriteLine(new string(arr1));
        }
    }
}