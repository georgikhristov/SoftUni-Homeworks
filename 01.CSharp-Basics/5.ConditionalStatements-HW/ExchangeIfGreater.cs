using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int help = a;
            a = b;
            b = help;
        }
        Console.WriteLine("{0} {1}",a,b);
    }
}

