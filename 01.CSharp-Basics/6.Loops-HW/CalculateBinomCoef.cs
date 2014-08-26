using System;

class CalculateBinomCoef
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        decimal k = int.Parse(Console.ReadLine());
        decimal result = 1;
        if (k > n-k)
        {
            for (int i = n; i > k; i--)
            {
                result *= i;
            }
            for (int i = 1; i <= n - k; i++)
            {
                result /= i;
            }
        }
        else
        {
            for (int i = n; i > n-k; i--)
            {
                result *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                result /= i;
            }
        }
        
        Console.WriteLine(result);
    }
}

