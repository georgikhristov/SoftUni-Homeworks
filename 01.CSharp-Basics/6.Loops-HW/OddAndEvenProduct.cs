using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenProduct *= num;
            }
            else
            {
                oddProduct *= num;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("even product = " + evenProduct);
            Console.WriteLine("odd product = " + oddProduct);
        }
    }
}

