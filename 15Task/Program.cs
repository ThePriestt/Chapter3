using System;

// Напишете програма, която разменя стойностите на битовете на позиции 3, 4 и 5 с битовете на позиции 24, 25 и 26 на дадено цяло положително число.

class Program
{
    static void Main()
    {
        //uint n = 88;

        //int p = 3;

        //int i = 1; 

        //uint mask = (uint)i << p;

        //Console.WriteLine(mask);

        //uint resoult = n & mask;

        //Console.WriteLine(resoult);

        //int v1 = (resoult == 0) ? 0 : 1;

        //Console.WriteLine(v1);


        //p = 24;

        //mask = (uint)i << p;

        //resoult = n & mask;

        //int v2 = (resoult == 0) ? 0 : 1;

        //Console.WriteLine(v2);

        //if (v2 == 0)
        //{
        //    Console.WriteLine(n & (~(i << 3)));
        //}
        //else
        //{
        //    Console.WriteLine(n | (i << 3));
        //}


        //if (v1 == 0)
        //{
        //    Console.WriteLine(n & (~(i << 24)));
        //}
        //else
        //{
        //    Console.WriteLine(n | (i << 24));
        //}

        uint n = 88;
        int j;
        uint mask;
        uint resoult;
        int v1;
        int v2;

        for (int i = 3; i < 6; i++)
        {
            j = i + 21;
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
        Console.WriteLine(n);
    }
}

