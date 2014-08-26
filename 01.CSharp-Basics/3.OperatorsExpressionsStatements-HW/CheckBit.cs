using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2));
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        bool isOne = (((number >> position) & 1) == 1) ? true : false;
        //Option 2:
        //int nToP = number >> position;
        //int bit = nToP & 1;
        //bool isOne = (bit == 1)? true : false;
        Console.WriteLine("The statement \"The bit at position {0} is 1\" is {1}",position, isOne);
    }
}

