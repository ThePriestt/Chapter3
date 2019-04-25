using System;

// Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.

class Program
{
    static void Main(string[] args)
    {
        int a = 12345678;
        int temp = a / 100;

        if (temp % 10 == 7)
        {
            Console.WriteLine("Третата цифра от дясно на ляво е 7");
        }
        else
        {
            Console.WriteLine("Третата цифра от дясно на ляво НЕ е 7");
        }
        Console.WriteLine("Третата цифра от дясно на ляво е {0}",temp % 10);
    }
}

