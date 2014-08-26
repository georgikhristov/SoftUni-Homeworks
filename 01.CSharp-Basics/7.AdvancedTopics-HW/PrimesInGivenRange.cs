using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Enter a start number: ");
        ulong startNum = ulong.Parse(Console.ReadLine());
        Console.Write("Enter an end number: ");
        ulong endNum = ulong.Parse(Console.ReadLine());
        List<ulong> primes = FindPrimesInRange(startNum, endNum);
        foreach (var num in primes)
        {
            Console.Write(num + ", ");
        }
    }
    static List<ulong> FindPrimesInRange(ulong startNum, ulong endNum)
    {
        List<ulong> primes = new List<ulong>();
        for (ulong i = startNum; i < endNum + 1; i++)
		{
            if (PrimeCheck(i))
            {
                primes.Add(i);
            }
		}
        return primes;
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

