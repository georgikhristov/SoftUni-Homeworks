using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
             Random randObj = new Random(i);
             Console.WriteLine(randObj.Next(min, max+1));
        }
    }
}

