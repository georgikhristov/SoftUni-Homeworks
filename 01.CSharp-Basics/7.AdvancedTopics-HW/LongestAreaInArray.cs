using System;
using System.Collections.Generic;
using System.Threading;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine();
        }
        Console.WriteLine();
        int length = 0;
        int newLength = 1;
        string equalElement = string.Empty;
        string newElement = strings[0];
        for (int i = 1; i < strings.Length; i++)
        {
            if (newElement == strings[i])
            {
                newLength++;
                if (newLength > length)
                {
                    length = newLength;
                    equalElement = newElement;
                }
            }
            else
            {
                newLength = 1;
                newElement = strings[i];
            }
        }
        Console.WriteLine(length);
        if (length == 1)
        {
            equalElement = strings[n - 1];
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(equalElement);
        }
    }
}