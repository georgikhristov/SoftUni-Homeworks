//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.

using System;
class NullValues
{
    static void Main(string[] args)
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("{0}\n{1}", intValue, doubleValue);
        Console.WriteLine("{0}\n{1}", intValue + 5, doubleValue - 150);
    }
}

