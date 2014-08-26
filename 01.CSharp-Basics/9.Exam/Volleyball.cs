using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double hometown = double.Parse(Console.ReadLine());
            double plays = 0;
            //hometown plays
            plays += hometown;
            //weekends
            plays += (48 - hometown) * 3 / 4;
            //holidays
            plays += holidays * 2 / 3;
            //leap year
            if (year == "leap")
            {
                plays += 0.15 * plays;
            }
            Console.WriteLine((int)plays);


        }
    }
}
