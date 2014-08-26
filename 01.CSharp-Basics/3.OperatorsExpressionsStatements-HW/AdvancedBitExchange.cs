using System;
class AdvancedBitExchange
{
    static void Main()
    {
        //Reading a number from the console and printing it in binary
        Console.Write("Enter an unsigned integer number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} in binary is: {1}", number, Convert.ToString(number, 2));
       
        //Creating bool variables that check for Overlap and Out of range
        bool overlap;
        bool outOfRange;
        
        //Reading first position and checking if it is out of range
        sbyte position1;
        do
        {
            Console.Write("Enter first position: ");
            position1 = sbyte.Parse(Console.ReadLine());
            outOfRange = (position1 < 0 || position1 > 31);
            if (outOfRange)
            {
                Console.WriteLine("Out of range!");
            }
        } while (outOfRange);

        //Reading second position and checking if it is out of range
        sbyte position2;
        do
        {
            Console.Write("Enter second position: ");
            position2 = sbyte.Parse(Console.ReadLine());
            outOfRange = (position2 < 0 || position2 > 31);
            if (outOfRange)
            {
                Console.WriteLine("Out of range!");
            }
        } while (outOfRange);

        //Reading the lenght and checking for overlap and out of range
        sbyte k;
        do
        {
            Console.Write("Enter lenght k = ");
            k=sbyte.Parse(Console.ReadLine());
            overlap = (Math.Abs(position1 - position2) <= k - 1);
            outOfRange = (position2 + k - 1 > 31 || position1 + k - 1 > 31);
            if (overlap)
            {
                Console.WriteLine("Overlapping!");
            }
            if (outOfRange)
            {
                Console.WriteLine("Out of range!");
                
            }
        } while (overlap || outOfRange);

        //Creating a mask with length k
        int mask = Convert.ToInt32(new string('1', k), 2);

        //Getting bits at position p,..,p+k-1
        int value1 = (int)((number >> position1) & mask);

        //Getting bits at position q,..,q+k-1
        int value2 = (int)((number >> position2) & mask);

        //Making bits at positions p,..,p+k-1 and q,..,q+k-1 zero
        number = (uint)(number & (~(mask << position1)));
        number = (uint)(number & (~(mask << position2)));

        //Making bits q,..,q+k-1 with the value of bits p,..,p+k-1
        number = (uint)(number | (value1 << position2));

        //Making bits p,..,p+k-1 with the value of bits q,..,q+k-1
        number = (uint)(number | (value2 << position1));

        //Printing the number with its binary representation to show that the bits are switched
        Console.WriteLine("The new number is: {0}", number);
        Console.WriteLine("Its binary representation is : {0}", Convert.ToString(number, 2));
    }
}
