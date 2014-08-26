using System;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double column = 0;
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            column += Math.Pow(26, n - i - 1) * (int)(str[0] - 64);
        }
        Console.WriteLine(column);
    }
}

