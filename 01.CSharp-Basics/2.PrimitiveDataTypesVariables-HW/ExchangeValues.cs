//Declare two integer variables a and b and assign them with 5 and 10 and
//after that exchange their values. Print the variable values before and after the exchange.

using System;
class ExchangeValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        int help;
        Console.WriteLine("Before exchange:\nFirstValue = {0}\nSecondValue = {1}\n", firstValue, secondValue);
        help = firstValue;
        firstValue = secondValue;
        secondValue = help;
        Console.WriteLine("After exchange:\nFirstValue = {0}\nSecondValue = {1}", firstValue, secondValue);
    }
}

