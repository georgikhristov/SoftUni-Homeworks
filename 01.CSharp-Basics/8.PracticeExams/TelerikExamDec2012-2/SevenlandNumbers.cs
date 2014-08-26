using System;

class SevenlandNumbers
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int next = 0;
        if (k % 10 == 6)
        {
            next = k + 4;
            if (next / 10 % 10 == 7)
            {
                next += 30;
            }
            if (next / 100 % 10 == 7)
            {
                next += 300;
            }
        }
        else
        {
            next = k + 1;
        }
        Console.WriteLine(next);
    }
}

