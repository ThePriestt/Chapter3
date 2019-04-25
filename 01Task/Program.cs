using System;

// Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

class Program
{
    static void Main()
    {
        int n = 20;

        if (n % 2 == 1)
        {
            Console.WriteLine("нечетно");
        }
        else
        {
            Console.WriteLine("четно");
        }
    }
}
