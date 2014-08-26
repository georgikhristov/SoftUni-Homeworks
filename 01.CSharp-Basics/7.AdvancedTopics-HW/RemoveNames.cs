using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.Write("Enter first list of names: ");
        string input = Console.ReadLine();
        List<string> firstList = input.Split().ToList();
        Console.Write("Enter second list of names: ");
        input = Console.ReadLine();
        List<string> secondList = input.Split().ToList();
        for (int i = 0; i < firstList.Count; i++)
        {
            for (int j = 0; j < secondList.Count; j++)
            {
                if (secondList[j] == firstList[i])
                {
                    firstList.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
        foreach (var name in firstList)
        {
            Console.WriteLine(name);
        }
    }
}

