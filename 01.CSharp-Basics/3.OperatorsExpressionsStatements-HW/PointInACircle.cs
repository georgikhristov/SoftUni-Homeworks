using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = false;
        if (x * x + y * y <= 2 * 2) isInCircle = true;
        Console.WriteLine(isInCircle); //"\"The point is in the circle\" is {0}", 
    }
}
