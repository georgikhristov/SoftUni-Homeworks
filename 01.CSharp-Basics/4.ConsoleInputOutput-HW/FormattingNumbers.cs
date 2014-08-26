using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number (0 <= a <= 500):");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter two floating-point numbers:");
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|",a,Convert.ToString(a, 2).PadLeft(10, '0'),b,c);
    }
}

