using System;

    class BeerTime
    {
        static void Main()
        {
            string time = String.Empty;
            int hour = 0, minute = 60;
            char period = ' '; // AM or PM
            bool valid = true;
            do
            {
                Console.WriteLine("Enter time in format \"hh:mm tt\"");
                time = Console.ReadLine();
                try
                {
                    hour = Convert.ToInt32(time[0]-48) * 10 + Convert.ToInt32(time[1]-48);
                    minute = Convert.ToInt32(time[3]-48) * 10 + Convert.ToInt32(time[4]-48);
                    period = time[6];
                }
                catch (System.FormatException)
                {
                    valid = false;
                }
                if (hour > 12 || hour < 1 || minute > 59 || (period != 'P' && period != 'A') 
                    || time[2] != ':' || time[5] != ' ' || time[7] != 'M')
                {
                    valid = false;
                }
                if (valid == false)
                {
                    Console.WriteLine("Invalid time");
                }
            } while (valid == false);
            if (period == 'A')
            {
                if (hour >= 3)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
    }

