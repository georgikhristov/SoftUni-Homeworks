//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateNfaktDivPowXN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        decimal x = int.Parse(Console.ReadLine());
        decimal sum = 1;
        int factorial = 1;
        decimal powerofX = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerofX *= x;
            sum += factorial / powerofX;
        }
        Console.WriteLine("sum = {0:F5}",sum);
    }
}

