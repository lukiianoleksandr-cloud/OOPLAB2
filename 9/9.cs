using System;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        foreach (char letter in word)
        {
            int index = letter - 'a';
            Console.WriteLine($"{letter}->{index}");
        }
    }
}