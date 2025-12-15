using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(' ').ToArray();
        string[] arr2 = Console.ReadLine().Split(' ').ToArray();

        int minLength = Math.Min(arr1.Length, arr2.Length);
        int leftCount = 0;
        int rightCount = 0;

        // Пошук зліва направо
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                leftCount++;
            }
            else
            {
                break;
            }
        }

        // Пошук справа наліво
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
            {
                rightCount++;
            }
            else
            {
                break;
            }
        }

        if (leftCount > rightCount)
        {
            Console.WriteLine("Найбільший спільний кінець є ліворуч: " + leftCount);
        }
        else if (rightCount > leftCount)
        {
            Console.WriteLine("Найбільший спільний кінець є праворуч: " + rightCount);
        }
        else if (leftCount > 0)
        {
            Console.WriteLine("Обидва кінці мають однакову довжину: " + leftCount);
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}