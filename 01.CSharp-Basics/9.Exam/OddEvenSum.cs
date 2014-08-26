using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= 2*n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += num;
            }
            else
            {
                oddSum += num;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(evenSum-oddSum));
        }
    }
}
