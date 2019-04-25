using System;

// Напишете програма, която разменя битовете на позиции {p, p+1, …, p+k-1) с битовете на позиции {q, q+1, …, q+k-1} на дадено цяло положително число.

class Program
{
    static void Main()
    {
        uint n = 88;
        uint mask;
        uint resoult;
        int v1;
        int v2;
        int k = 2;
        int p = 4;
        int q = 3;

        for (int i = p; i <= p + k - 1; i++)
        {
            for (int j = q; j <= q + k - 1; j++)
            {
                mask = (uint)1 << i;
                resoult = n & mask;
                v1 = (resoult == 0) ? 0 : 1;
                mask = (uint)1 << j;
                resoult = n & mask;
                v2 = (resoult == 0) ? 0 : 1;

                if (v2 == 0)
                {
                    n = (uint)(n & (~(1 << i)));
                }
                else
                {
                    n = (uint)(n | (1 << i));
                }

                if (v1 == 0)
                {
                    n = (uint)(n & (~(1 << j)));
                }
                else
                {
                    n = (uint)(n | (1 << j));
                }
            }

     
        }
        Console.WriteLine(n);
    }
}   
    


