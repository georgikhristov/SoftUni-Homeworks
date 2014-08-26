using System;
    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            int position = 3;
            int nRightP = number >> position;
            byte bit = checked((byte)(nRightP & 1));
            Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The bit at position 3 is: {0}", bit);
        }
    }

