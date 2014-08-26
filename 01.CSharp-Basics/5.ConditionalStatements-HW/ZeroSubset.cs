using System;
class ZeroSubset
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;
        bool isZero = false;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number {0}: ",i+1);
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        if (sum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            isZero = true;
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j < 5; j++)
			{
			    sum = numbers[i]+numbers[j];
                if (sum == 0 && i!=j)
                {
                    Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[j]);
                    isZero = true;
                }
			}
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 1; j < 4; j++)
			{
			    for (int k = 2; k < 5; k++)
			    {
			        sum = numbers[i] + numbers[j] + numbers[k];
                    if (sum == 0 && i!=j && j!=k)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                        isZero = true;
                    }
			    }
			}
        }
        if (numbers[0] + numbers[1] + numbers[2] + numbers [3] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0",numbers[0],numbers[1],numbers[2],numbers[3]);
            isZero = true;
        }
        if (numbers[0] + numbers[1] + numbers[2] + numbers [4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0",numbers[0],numbers[1],numbers[2],numbers[4]);
            isZero = true;
        }
        if (numbers[0] + numbers[1] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[1], numbers[3], numbers[4]);
            isZero = true;
        }
        if (numbers[0] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[2], numbers[3], numbers[4]);
            isZero = true;
        }
        if (numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[1], numbers[2], numbers[3], numbers[4]);
            isZero = true;
        }
        if (!isZero)
        {
            Console.WriteLine("There is no zero subset");
        }

    }
}

