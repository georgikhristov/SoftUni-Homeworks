using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        int nRightP = number >> position;
        byte bit = checked((byte) (nRightP & 1));
        Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("The bit at position {0} is: {1}", position, bit);
    }
}

