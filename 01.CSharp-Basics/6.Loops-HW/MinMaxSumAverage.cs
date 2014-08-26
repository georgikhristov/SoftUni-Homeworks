using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (max < num) max = num;
            if (min > num) min = num;
            sum += num;
        }
        double average = ((double)sum) / n;
        Console.WriteLine("max = " + max);
        Console.WriteLine("min = " + min);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("average = {0:F2}",average);
    }
}

