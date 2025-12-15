using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p] == true)
            {
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == true)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}