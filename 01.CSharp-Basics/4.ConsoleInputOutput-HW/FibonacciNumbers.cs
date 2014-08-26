using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer number: ");
        uint n = uint.Parse(Console.ReadLine());
        for (uint i = 0; i < n; i++)
        {
            Console.Write(Fibbonaci(i) + " ");
        }
    }
    static int Fibbonaci(uint n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibbonaci(n - 1) + Fibbonaci(n - 2);
    }
}

