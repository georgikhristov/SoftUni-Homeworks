using System;

class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter a 4-digit number: ");
        do
	    {
	        Console.Write("Enter a 4-digit number: ");
            num = int.Parse(Console.ReadLine());
            if (num < 1000 || num > 9999) Console.WriteLine("Invalid number!");
	    } while (num < 1000 || num > 9999);
        int firstDigit = num % 10;
        int secondDigit = num / 10 % 10;
        int thirdDigit = num / 100 % 10;
        int fourthDigit = num / 1000;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        int reverseNum = firstDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + fourthDigit;
        int lastToFront = firstDigit * 1000 + num / 10;
        int secondToThird = fourthDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + firstDigit;
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The reverse number is: {0}", reverseNum);
        Console.WriteLine("The number when the last digits is in front is: {0}", lastToFront);
        Console.WriteLine("The number when we exchange the second and the third digit is: {0}", secondToThird);
    }
}

