using System;
class RectangleAreaPerimeter
{
    static void Main()
    {
        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the heigth: ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = 2*(width + height);
        Console.WriteLine("The area is: {0}\nThe perimeter is: {1}", area, perimeter);
    }
}