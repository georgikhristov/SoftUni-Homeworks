using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double num;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter a number: ");
            num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}

