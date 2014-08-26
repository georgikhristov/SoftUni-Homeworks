using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(gcd(a,b));
    }
    static int gcd (int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (b > a)
        {
            int help = a;
            a = b;
            b = help;
        }
        int gcd = 1;
        int remainder = 0;
        while (true)
        {
            remainder = a % b;
            if (remainder > 1)
            {
                a = b;
                b = remainder;
                continue;
            }
            if (remainder == 1)
            {
                return gcd;
            }
            if (remainder == 0)
            {
                return gcd = b;
            }
        }
    }
}

