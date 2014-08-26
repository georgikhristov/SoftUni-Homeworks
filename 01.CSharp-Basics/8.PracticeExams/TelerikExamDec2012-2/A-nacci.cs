using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second =  Console.ReadLine();
        int l = int.Parse(Console.ReadLine());
        Console.WriteLine(first);
        for (int i = 0; i < l - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}", Anacci(first[0], second[0], (i + 1) * 2), new string(' ', i),
                Anacci(first[0], second[0], (i + 1) * 2 + 1));
        }
    }
    static char Anacci(char first, char second, int n)
    {
        if (n == 1)
        {
            return first;
        }
        if (n == 2)
        {
            return second;
        }
        char letter = (char)0;
        for (int i = 2; i < n; i++)
        {
            letter = (char)((first + second - 129) % 26 + 65);
            first = second;
            second = letter;
        }
        return letter;
    }
}

