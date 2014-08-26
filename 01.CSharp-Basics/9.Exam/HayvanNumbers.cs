using System;

class Program
{
    static void Main(string[] args)
    {
        int targetSum = int.Parse(Console.ReadLine());
        int targetDiff = int.Parse(Console.ReadLine());
        bool numberFound = false;
        for (int d1 = 5; d1 < 10; d1++)
            for (int d2 = 5; d2 < 10; d2++)
                for (int d3 = 5; d3 < 10; d3++)
                    for (int d4 = 5; d4 < 10; d4++)
                        for (int d5 = 5; d5 < 10; d5++)
                            for (int d6 = 5; d6 < 10; d6++)
                                for (int d7 = 5; d7 < 10; d7++)
                                    for (int d8 = 5; d8 < 10; d8++)
                                        for (int d9 = 5; d9 < 10; d9++)
                                        {
                                            int sum = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9;
                                            if (sum != targetSum)
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                int abc = d1 * 100 + d2 * 10 + d3;
                                                int def = d4 * 100 + d5 * 10 + d6;
                                                int ghi = d7 * 100 + d8 * 10 + d9;
                                                int diff = ghi - def;
                                                if ((diff == def - abc) && (diff == targetDiff))
                                                {
                                                    Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                    numberFound = true;
                                                }
                                            }
                                        }
        if (numberFound == false)
        {
            Console.WriteLine("No");
        }
    }
}

