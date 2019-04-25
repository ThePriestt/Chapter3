using System;

// Напишете израз, който изчислява площта на трапец по дадени a, b и h.

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 8;
        int h = 9;

        double S = ((a + b) / 2.0) * h;

        Console.WriteLine(S);
    }
}

