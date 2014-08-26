using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSums
{
    static void Main()
    {
        long targetSum = long.Parse(Console.ReadLine());
        long sum = 0;
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 1; i < Math.Pow(2,n); i++)
        {
            string str = Convert.ToString(i, 2).PadLeft(n,'0');
            for (int j = 0; j < n; j++)
            {
                sum += Convert.ToInt32(str[j]- 48) * numbers[j];
            }
            if (sum == targetSum)
            {
                count++;
            }
            sum = 0;
        }
        Console.WriteLine(count);
    }
}

