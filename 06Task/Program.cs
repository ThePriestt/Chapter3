using System;

// Напишете програма, която за подадени от потребителя дължина и височина на право­ъгълник, пресмята и отпечатва на конзолата неговия периметър и лице.

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        // string s = Console.ReadLine();

        Console.WriteLine("Please enter a");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(a * b);        
    }
}

