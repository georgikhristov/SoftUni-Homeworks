using System;

class PlayCards
{
    static void Main()
    {
        object card = Console.ReadLine();
        try
        {
            if ((Convert.ToInt32(card) >= 2 && Convert.ToInt32(card) <= 10))
            {
                Console.WriteLine("yes");
            }
            else if (!(Convert.ToInt32(card) >= 2 && Convert.ToInt32(card) <= 10))
            {
                Console.WriteLine("no");
            }
        }
        catch (System.FormatException)
        {
            if (Convert.ToString(card) == "J" || Convert.ToString(card) == "Q" ||
                Convert.ToString(card) == "K" || Convert.ToString(card) == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

