using System;
    class TribonacciTriangle
    {
        static void Main()
        {
            long lastNum = int.Parse(Console.ReadLine());
            long secLastNum = int.Parse(Console.ReadLine());
            long thirdlastNum = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            long currentNum = lastNum + secLastNum + thirdlastNum;
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0 && j == 0) Console.Write(lastNum + "\n");
                    else if (i == 1 && j == 0) Console.Write(secLastNum + " ");
                    else if (i == 1 && j == 1) Console.Write(thirdlastNum + "\n");
                    else
                    {
                        currentNum = lastNum + secLastNum + thirdlastNum;
                        Console.Write(currentNum);
                        lastNum = secLastNum;
                        secLastNum = thirdlastNum;
                        thirdlastNum = currentNum;
                        if (j != i) Console.Write(" ");
                        else Console.WriteLine();
                    }
                }
            }
        }
    }

