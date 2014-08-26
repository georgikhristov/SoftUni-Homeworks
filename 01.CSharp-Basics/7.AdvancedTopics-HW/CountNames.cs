using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountNames
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        var countNames = new Dictionary<string, int>();
        for (int i = 0; i < input.Count; i++)
        {
            if (countNames.ContainsKey(input[i]))
            {
                countNames[input[i]] += 1;
            }
            else
            {
                countNames.Add(input[i], 1);
            }
        }
        foreach (var name in countNames)
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }
    }
}

