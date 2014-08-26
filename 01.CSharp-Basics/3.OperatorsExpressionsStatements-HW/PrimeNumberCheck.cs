using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = false;
        if ( ( (num % 2 != 0) && (num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0) && (num > 1) ) 
            || (num == 2) || (num == 3) || (num == 5) || (num == 7) ) 
            isPrime = true;
        Console.WriteLine(isPrime);
    }
}

