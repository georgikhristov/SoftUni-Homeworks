using System;

class MatrixOfPalindroms
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter a number of columns: ");
        int columns = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0}{1}{0} ", (char)('a' + i), (char)('a' + j));
            }
            Console.WriteLine();
        }
    }
}

