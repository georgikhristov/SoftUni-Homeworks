using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        Console.WriteLine(PrimeCheck(number));
    }
    static bool PrimeCheck (ulong number)
    {
        ulong divider = 2;
        ulong maxDivider = (ulong)Math.Sqrt(number);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        return prime;
    }
}

