using System;

    class IsThirdDigit7
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isThirdDigit = false;
            if ((num / 100) % 10 == 7) isThirdDigit = true;
            Console.WriteLine("\"The third digit is 7\" is {0}", isThirdDigit);
        }
    }

