using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] votes = new int[n];
        for (int i = 0; i < votes.Length; i++)
        {
            int catNumber = int.Parse(Console.ReadLine());
            votes[catNumber - 1]++;
        }
        int maxVotes = votes[0];
        int winner = 1;
        for (int i = 0; i < votes.Length; i++)
        {
            if (votes[i] > maxVotes)
            {
                maxVotes = votes[i];
                winner = i + 1;
            }
        }
        Console.WriteLine(winner);
    }
}

