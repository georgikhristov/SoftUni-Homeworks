using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= (double)(n + i) / i;
        }
        Console.WriteLine("{0:#}",result);
    }
}

