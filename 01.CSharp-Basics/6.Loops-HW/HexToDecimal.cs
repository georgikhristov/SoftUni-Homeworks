using System;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hex = Console.ReadLine();
        long num = 0;
        long power = 1;
        bool valid = true;
        int digit = 0;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case '0': digit = 0; break;
                case '1': digit = 1; break;
                case '2': digit = 2; break;
                case '3': digit = 3; break;
                case '4': digit = 4; break;
                case '5': digit = 5; break;
                case '6': digit = 6; break;
                case '7': digit = 7; break;
                case '8': digit = 8; break;
                case '9': digit = 9; break;
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: valid = false; break;
            }
            if (!valid)
            {
                break;
            }
            num += digit * power;
            power *= 16;
        }
        if (valid)
        {
            Console.WriteLine(num);  
        }
        else
        {
            Console.WriteLine("That is not a valid hexadecimal number!");
        }
    }
}

