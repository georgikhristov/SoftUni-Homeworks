using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        foreach (var num in numbers)
        {
            //creating reverse number
            string str = Convert.ToString(num, 2);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            int reverse = Convert.ToInt32(new string(arr), 2);
            Console.WriteLine(reverse);
        }
    }
}

