using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string asterixes = new string('*', 2 * n - 2);
        string glasses = new string('/', 2 * n - 2);
        string intervals = new string(' ', n-1);
        string bridge = new string('-', n-1);
        Console.WriteLine(" {0} {1} {0} ", asterixes, intervals);
        for (int i = 1; i < n-1; i++)
        {
            if (i != n/2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", glasses, intervals);
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", glasses, bridge);
            }
        }
        Console.WriteLine(" {0} {1} {0} ", asterixes, intervals);
    }
}

