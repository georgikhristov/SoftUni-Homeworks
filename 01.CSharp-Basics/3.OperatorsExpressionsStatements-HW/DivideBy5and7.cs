using System;

class DivideBy5and7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool divide = false;
        if (num % 35 == 0) divide = true;
        Console.WriteLine("\"The number divides by 5 and 7\" is {0}.", divide);
    }
}

