using System;

// Дадено е число n, стойност v (v = 0 или 1) и позиция p. Напишете поредица от операции, които да променят стойността на n, така че битът на позиция p да има стойност v.
// Пример n=35, p=5, v=0 -> n=3. Още един пример: n=35, p=2, v=1 -> n=39.

class Program
{
    static void Main()
    {
        int n = 35;
        int p = 5;
        int v = 0;

        Console.WriteLine(n & (~(1 << p)));

        n = 35;
        p = 2;
        v = 1;

        Console.WriteLine(n | (1 << p));
    }
}

