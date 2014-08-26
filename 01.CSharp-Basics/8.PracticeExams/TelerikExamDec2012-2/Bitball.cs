using System;

class Bitball
{
    static void Main()
    {
        int n = 8;
        int[] topTeam = new int[n];
        int[] bottomTeam = new int[n];
        int[] playfield = new int[n];
        for (int i = 0; i < n; i++)
        {
            topTeam[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            bottomTeam[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            playfield[i] = topTeam[i] ^ bottomTeam[i];
        }

        int resultTop = 0;
        int resultBottom = 0;

        for (int i = 0; i < n; i++)
        {
            for (int p = 0; p < n; p++)
            {
                if (((topTeam[i] >> p) & 1) == 1 && ((playfield[i] >> p) & 1) == 1)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (((playfield[j] >> p) & 1) == 0)
                        {
                            if (j == n - 1)
                            {
                                resultTop++;
                            }
                            continue;
                        }
                        else break;
                    }
                    if (i == 7)
                    {
                        resultTop++;
                    }
                }
                if (((bottomTeam[i] >> p) & 1) == 1 && ((playfield[i] >> p) & 1) == 1)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (((playfield[j] >> p) & 1) == 0)
                        {
                            if (j == 0)
                            {
                                resultBottom++;
                            }
                            continue;
                        }
                        else break;
                    }
                    if (i == 0)
                    {
                        resultBottom++;
                    }
                }
            }
        }

        Console.WriteLine("{0}:{1}",resultTop,resultBottom);

    }
}

