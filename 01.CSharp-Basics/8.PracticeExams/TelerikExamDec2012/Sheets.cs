using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string str = Convert.ToString(n, 2);
            ulong binary = Convert.ToUInt64(str);
            for (int i = 1; i <= 11; i++)
            {
                if (binary % 10 == 0)
                {
                    Console.WriteLine("A{0}", 11-i);
                }
                binary /= 10;
            }

        }
    }

