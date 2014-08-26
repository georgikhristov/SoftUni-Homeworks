using System;

class BiggestOf5Numbers
{
    static void Main()
    {
        double[] numbers = new double[5];
        double max = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = double.Parse(Console.ReadLine());
            if (i == 0)
            {
                max = numbers[i];
            }
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine(max);
    }
}

