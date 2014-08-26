using System;

class FibonacciNumbers
{
    static void Main()
    {
            Console.Write("Enter an unsigned integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
    }
    static int Fib(uint n)
    {
        if (n == 0) return 1;
        if (n == 1) return 1;
        return Fib(n - 1) + Fib(n - 2);
    }
}
