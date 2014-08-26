using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        
        //Console.WriteLine("Enter the coordinates of the center of the circle");
        //Console.Write("x = ");
        double circleX = 1; //double.Parse(Console.ReadLine());
        //Console.Write("y = ");
        double circleY = 1; //double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the radius of the circle");
        //Console.Write("r = ");
        double radius = 1.5; //double.Parse(Console.ReadLine());
        
        //Console.WriteLine("Enter the coordinates of the top left vertex of the rectangle");
        //Console.Write("top = ");
        double recX = 1; // double.Parse(Console.ReadLine());
        //Console.Write("left = ");
        double recY = -1; // double.Parse(Console.ReadLine());
        //Console.Write("width = ");
        double width = 6; // double.Parse(Console.ReadLine());
        //Console.Write("heigth = ");
        double height = 2; //double.Parse(Console.ReadLine());
       
        bool isInCircle = false;
        if ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= radius * radius)
            isInCircle = true;
        bool isOutOfRectangle = false;
        if (!((x < recX || x > recX + width) && (y < recY - height || y > recY)))
            isOutOfRectangle = true;
        Console.WriteLine("The point is in the circle : {0}", isInCircle);
        Console.WriteLine("The point is out of the rectangle : {0}", isOutOfRectangle);
        Console.WriteLine("Both : {0}", isInCircle && isOutOfRectangle);

    }
}

