using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long num = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        while (num > 0)
        {
            switch (num % 2)
            {
                case 0: binary = '0' + binary; break;
                case 1: binary = '1' + binary; break;
            }
            num /= 2;
        }
        if (binary == string.Empty)
        {
            binary = "0";
        }
        Console.WriteLine(binary);
    }
}

