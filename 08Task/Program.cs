using System;

// Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.

class Program
{
    static void Main()
    {
        int x = 2;
        int y = 3;
        // bool isIn = x * x + y * y < 5 * 5;
        Console.WriteLine("The point is inside the circle: {0}", x * x + y * y < 5 * 5);
    }
}

