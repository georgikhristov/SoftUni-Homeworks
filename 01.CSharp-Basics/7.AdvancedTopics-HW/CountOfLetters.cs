using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfLetters
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        var countLetters = new Dictionary<string,int>();
        for (int i = 0; i < input.Count; i++)
        {
            if (countLetters.ContainsKey(input[i]))
            {
                countLetters[input[i]] += 1;
            }
            else
            {
                countLetters.Add(input[i], 1);
            }
        }
        foreach (var letter in countLetters)
	    {
		     Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
	    }
    }
}

