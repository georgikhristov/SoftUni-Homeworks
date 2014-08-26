using System;

class CalculateNfaktDivKfakt
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        decimal k = int.Parse(Console.ReadLine());
        decimal result = 1;
        for (int i = n; i > k; i--)
        {
            result *= i;
        }
        Console.WriteLine("result = " + result);
    }
}

