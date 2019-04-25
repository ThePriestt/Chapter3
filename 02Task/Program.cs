using System;

// Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

class Program
{
    static void Main()
    {
        int i = 21;

        if (i % 5 == 0)
        {
            Console.WriteLine("Числото {0} се дели без остатък на 5", i);
        }
        else
        {
            Console.WriteLine("Числото {0} НЕ се дели без остатък на 5", i);
        }

        if (i % 7 == 0)
        {
            Console.WriteLine("Числото {0} се дели без остатък на 7", i);
        }
        else
        {
            Console.WriteLine("Числото {0} НЕ се дели без остатък на 7", i);
        }
    }
}

