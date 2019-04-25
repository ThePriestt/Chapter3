using System;

// Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.

class Program
{
    static void Main(string[] args)
    {
        byte a = 11;
        if ((a & 8) == 0)
        {
            Console.WriteLine("Третият бит е 0");
        }
        else
        {
            Console.WriteLine("Третият бит е 1");
        }
    }
}

