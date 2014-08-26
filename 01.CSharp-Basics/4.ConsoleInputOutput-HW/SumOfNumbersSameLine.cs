using System;

class SumOfNumbersSameLine
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers on the same line : ");
        string[] numbers = Console.ReadLine().Split();
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine("The sum is : {0}",sum);
    }
}

