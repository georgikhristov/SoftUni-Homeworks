using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        //creating a list and adding the first sequence of elements
        Console.Write("Enter first list of numbers: ");
        string input = Console.ReadLine();
        List<string> list = input.Split().ToList();

        //adding the second sequence of elements
        Console.Write("Enter second list of numbers: ");
        input = Console.ReadLine();
        list.AddRange(input.Split().ToList());

        //removing the equal elements
        List<string> distinct = list.Distinct().ToList();

        //making the strings into numbers
        List<int> numbers = distinct.Select(int.Parse).ToList();

        //sorting the numbers
        numbers.Sort();

        //printing the result
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

