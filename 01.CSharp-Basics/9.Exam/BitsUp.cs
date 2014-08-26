using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitsUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            i = 0;
            int p = 1;
            while (i < n)
            {
                numbers[i] = numbers[i] | (1 << (7 - p));
                p += step;
                i += p / 8;
                p %= 8;
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
