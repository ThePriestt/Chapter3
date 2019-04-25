using System;

// Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто (т.е. се дели без остатък само на себе си и на единица).

class Program
{
    static void Main()
    {
        int n = 57;
        bool isPrime = true;

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine("The number {0} isPrime: {1}", n, isPrime);
    }
}

