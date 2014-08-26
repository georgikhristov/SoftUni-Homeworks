using System;
class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2));
       
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        
        Console.Write("Enter a value of a bit: ");
        byte value = byte.Parse(Console.ReadLine());
        
        int bit = (number >> position) & 1;
        if (value == 1)
        {
            number = number | (1 << position);
        }
        else
        {
            number = number & ~(1 << position);
        }
       
        Console.WriteLine("The new number is: {0}\nIn binary: {1}", number, Convert.ToString(number,2));
    }
}

