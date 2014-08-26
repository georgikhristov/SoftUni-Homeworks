using System;

    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            if (day <= 27) Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
            if (day == 28 && month == 2)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                }
                else
                {
                    Console.WriteLine("1.{0}.{1}", month + 1, year);
                }
            }
            if (day == 29)
            {
                if (month == 2 && year % 4 == 0)
                    Console.WriteLine("1.{0}.{1}", month + 1, year);
                else
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
            }
            if (day == 30)
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("{0}.{1}.{2}", 1, month + 1, year);
                }
                else Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
            }
            if (day == 31 && month != 12)
                Console.WriteLine("{0}.{1}.{2}", 1, month + 1, year);
            if (day == 31 && month == 12) Console.WriteLine("{0}.{1}.{2}", 1, 1, year + 1);
        }
    }

