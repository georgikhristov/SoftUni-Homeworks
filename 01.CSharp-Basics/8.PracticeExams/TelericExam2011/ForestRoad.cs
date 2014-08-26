using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}", new string('.', i), new string('.', n - 1 - i));
        }
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{1}*{0}", new string('.', i), new string('.', n - 1 - i));
        }
    }
}

