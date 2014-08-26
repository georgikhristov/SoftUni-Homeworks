using System;
using System.Collections.Generic;

class RandomOrderOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        Random rand = new Random();
        while (numbers.Count > 0)
        {
            int index = rand.Next(numbers.Count);
            Console.Write(index + " ");
            Console.WriteLine(numbers[index]); 
            numbers.RemoveAt(index);
        }
    }
}

