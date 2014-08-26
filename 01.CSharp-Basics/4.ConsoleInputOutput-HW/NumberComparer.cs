using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        double b = double.Parse(Console.ReadLine());
        double max = (a + b + Math.Abs(a - b)) / 2;
        //Second option:
        //max = (a > b) ? a : b;
        Console.WriteLine("The bigger one is {0}",max);
    }
}

