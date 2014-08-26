using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coeficients of the quadratic equation:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        double x1, x2;
        if (d < 0) Console.WriteLine("There are no real roots");
        if (d == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        if (d > 0)
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}

