using System;

class TelericLogo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{1}*{0}", new string('.',n/2), new string('.',2*n-3));
        for (int i = 1; i < n/2+1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string ('.', n/2 - i), new string('.',2*i-1), new string('.',2*n-3-2*i));
        }
        for (int i = n/2 - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.',3*n/2-i-1), new string ('.', 2*i-1));
        }

        Console.WriteLine("{0}*{0}", new string ('.',n-1+n/2));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.',n-i-1+n/2), new string ('.', 2*i-1));
        }
        for (int i = n-2; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - i - 1+n/2), new string('.', 2 * i - 1));
        }
        Console.WriteLine("{0}*{0}", new string('.', n - 1+n/2));
    }
}

