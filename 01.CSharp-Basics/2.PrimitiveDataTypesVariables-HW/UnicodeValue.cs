﻿//Declare a character variable and assign it with the symbol 
//that has Unicode code 72, and then print it. 
//Hint: first, use the Windows Calculator to find 
//the hexadecimal representation of 72. The output should be “H”.

using System;

namespace UnicodeValue
{
    class UnicodeValue
    {
        static void Main(string[] args)
        {
            char symbol = (char)72;
            Console.WriteLine(symbol);
        }
    }
}
