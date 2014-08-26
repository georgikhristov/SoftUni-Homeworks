using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int myInt = int.Parse(Console.ReadLine());
        Console.WriteLine((myInt % 2 == 0)? true:false); 
    }
}

