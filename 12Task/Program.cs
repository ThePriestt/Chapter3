using System;

// Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1. Пример v=5, p=1 -> false.

class Program
{
    static void Main()
    {
        int v = 5; // 00100011

        int p = 2;

        int i = 1; // 00000001

        int mask = i << p; // Move the 1st bit left by p positions

        Console.WriteLine((v & mask) != 0 ? 1 : 0);

        // Short way:
        Console.WriteLine((v & (1 << p)) != 0);      
    }
}

