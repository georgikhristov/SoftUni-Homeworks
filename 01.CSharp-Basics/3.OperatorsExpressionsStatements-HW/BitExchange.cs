//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitExchange
{
    static void Main(string[] args)
    {
        //Reading a number from the console
        Console.Write("Enter an integer number: ");
        uint number = uint.Parse(Console.ReadLine());
        
        //Printing its binary representation
        Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2));
        
        sbyte position1 = 3;
        sbyte position2 = 24;
        
        //Getting bits at position 3,4,5
        int value1 = (int)((number >> position1) & 7);
        
        //Getting bits at position 24 25 26
        int value2 = (int)((number >> position2) & 7);
       
        //Making bits at positions 3,4,5,24,25,26 zero
        number = (uint)( number & (~(7 << position1)) );
        number = (uint)( number & (~(7 << position2)) );
       
        //Making bits 24,25,26 with the value of bits 3,4,5
        number = (uint) (number | (value1 << position2));
       
        //Making bits 3,4,5 with the value of bits 24,25,26
        number = (uint)(number | (value2 << position1));
       
        //Printing the number with its binary representation to show that the bits are switched
        Console.WriteLine("The new number is: {0}",number);
        Console.WriteLine("Its binary representation is : {0}", Convert.ToString(number, 2));
    }
}