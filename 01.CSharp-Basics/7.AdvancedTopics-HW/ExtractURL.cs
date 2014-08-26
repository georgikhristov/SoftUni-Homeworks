using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractURL
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        var urls = new List<string>();
        foreach (var word in words)
        {
            if (StringStartsWith(word, "http://") || StringStartsWith(word, "www."))
            {
                urls.Add(word);
            }
        }
        for (int i = 0; i < urls.Count; i++)
        {
            if (urls[i][urls[i].Length - 1] == '.') //if the last symbol of the word is '.'
            {
                urls[i] = urls[i].Remove(urls[i].Length - 1); //remove the last symbol
            }
        }
        foreach (var url in urls)
        {
            Console.WriteLine(url);
        }

    }
    static bool StringStartsWith(string str, string start)
    {
        bool starts = true;
        if (str.Length < start.Length)
        {
            starts = false;
        }
        else for (int i = 0; i < start.Length; i++)
        {
            if (start[i] != str[i])
            {
                starts = false;
                break;
            }
        }
        return starts;
    }
}

