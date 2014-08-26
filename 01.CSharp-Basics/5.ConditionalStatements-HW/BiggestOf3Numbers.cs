using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double max = a;
        if (max < b) max = b;
        if (max < c) max = c;
        Console.WriteLine(max);
    }
}

