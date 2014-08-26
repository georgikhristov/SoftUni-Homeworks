using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int count;
        int row, column;
        int startRow = 0;
        int startColumn = 0;
        int stopRight = n - 1;
        int stopLeft = 0;
        int num = 1;
        for (count = 1; count <= 2 * n - 1; count++)
        {
            switch (count % 4)
            {
                //right
                case 1:
                    {
                        for (row = startRow, column = startColumn; column <= stopRight; column++, num++)
                            matrix[row,column] = num;
                        startRow = row + 1;
                        startColumn = column - 1;
                        break;
                    }
                //down
                case 2:
                    {
                        for (row = startRow, column = startColumn; row <= stopRight; row++, num++)
                            matrix[row,column] = num;
                        startRow = row - 1;
                        startColumn = column - 1;
                        stopRight--;
                        break;
                    }
                //left
                case 3:
                    {
                        for (row = startRow, column = startColumn; column >= stopLeft; column--, num++)
                            matrix[row,column] = num;
                        startRow = row - 1;
                        startColumn = column + 1;
                        stopLeft++;
                        break;
                    }
                //up
                case 0:
                    {
                        for (row = startRow, column = startColumn; row >= stopLeft; row--, num++)
                            matrix[row,column] = num;
                        startRow = row + 1;
                        startColumn = column + 1;
                        break;
                    }
            }
        }
        for (row = 0; row < n; row++)
        {
            for (column = 0; column < n; column++)
            {
                Console.Write("{0,-5}",matrix[row,column]);
            }
            Console.WriteLine();
        }
    }
}

