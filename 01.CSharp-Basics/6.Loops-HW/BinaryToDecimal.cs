using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        long num = 0;
        long power = 1;
        bool valid = true;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            switch (binary[i])
            {
                case '0': continue;
                case '1': num += power; break;
                default: valid = false; break;
            }
            if (!valid)
            {
                break;
            }
            power *= 2;
        }
        if (valid)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine("That is not a valid binary number!");
        }
    }
}

