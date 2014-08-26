using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrailingZerosInNfakt
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int j = i;
            while (j%5 == 0)
            {
                count++;
                j /= 5;
            }
        }
        Console.WriteLine(count);
    }
}

