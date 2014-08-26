using System;
class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("The perimeter is {0:F2}",perimeter);
            Console.WriteLine("The area is {0:F2}", area);
        }
    }

