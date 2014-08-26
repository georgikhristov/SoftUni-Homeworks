using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestWord
{
    static void Main()
    {
        string text = Console.ReadLine();
        string longestWord = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            string word = string.Empty;
            int j = i;
            while ((text[j]>=97 && text[j] <=122) || (text[j]>=65 && text[j]<=90)) //while (the symbol is a letter)
            {
                word += text[j]; //add this letter to word
                j++; //go to next letter
            }
            i = j; // now that the loop is over, it means that text[j] is not a letter, we need to test from the next symbol
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine(longestWord);
    }
}

