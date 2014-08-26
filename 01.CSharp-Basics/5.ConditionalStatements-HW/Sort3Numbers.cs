using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (b > c) // a > b > c
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else // c > b
            {
                if (a > c) // a > c > b
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                else // c > a > b
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
        }
        else // b > a
        {
            if (a > c) // b > a > c
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else // c > a
            {
                if (b > c) // b > c > a
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else // c > b > a
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}

