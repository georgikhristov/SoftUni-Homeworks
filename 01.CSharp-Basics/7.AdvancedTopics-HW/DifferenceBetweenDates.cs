using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = secondDate - firstDate;    
        Console.WriteLine(difference.Days);
    }
}

