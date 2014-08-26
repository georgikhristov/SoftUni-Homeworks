using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter a start point : ");
        double start = double.Parse(Console.ReadLine());
        if ( (int)start - start != 0) start ++ ;
        Console.Write("Enter an end point : ");
        double end = double.Parse(Console.ReadLine());
        int count = 0;
        //Console.Write("Enter a number to divide : ");
        int num = 5; //int.Parse(Console.ReadLine());
        //Console.Write("Enter a reminder : ");
        int remainder = 0; //int.Parse(Console.ReadLine());
        for (int i = (int)start; i <= end; i++)
        {
            if (i % num == remainder)
            {
                count++;
                //Console.WriteLine(i);
            }
        }
        Console.WriteLine("The count is : " + count);
    }
}

