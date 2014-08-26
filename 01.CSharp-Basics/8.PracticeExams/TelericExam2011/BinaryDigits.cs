using System;

class BinaryDigits
{
    static void Main()
    {
        string b = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        uint[] numbers = new uint[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            string str = Convert.ToString(numbers[i], 2);
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == b[0])
                {
                    count++;  
                }
            }
            Console.WriteLine(count);
        }
    }
}

