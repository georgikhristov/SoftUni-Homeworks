using System;

class GravityOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your weight : ");
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = 0.17 * weight;
        Console.WriteLine("Your weight on the Moon is {0}kg", weightMoon);
        
    }
}

