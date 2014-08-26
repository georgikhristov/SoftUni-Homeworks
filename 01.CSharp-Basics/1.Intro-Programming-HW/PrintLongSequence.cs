using System;
class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.Write(Math.Pow(-1, i) * i + " ");
        }
    }
}