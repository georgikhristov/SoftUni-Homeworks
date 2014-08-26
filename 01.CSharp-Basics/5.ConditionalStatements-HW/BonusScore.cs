using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());
        if (score < 1 || score > 9)
        {
            Console.WriteLine("Invalid score!");
        }
        else
        {
            if (score >= 1 && score <= 3)
            {
                score *= 10;
            }
            if (score >=4 && score <= 6)
            {
                score *= 100;
            }
            if (score >=7 && score <=9)
            {
                score *= 1000;
            }
        }
        Console.WriteLine("Your bonus score is: {0}", score);
    }
}

