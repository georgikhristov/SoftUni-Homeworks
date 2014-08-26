using System;

class AgeAfterTenYears
{
    static void Main()
    {
        //Reading your birthday
        //For example 18.03.1990
        Console.Write("Enter your birthday:");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        //Creating a variable with today's date
        //For example 14.03.2014
        DateTime today = DateTime.Today;

        //Caluculating your age
        //age = 2014 - 1990 = 24
        int age = today.Year - birthday.Year;

        //If yor birthdate is bigger than today's date minus your age, 1 is substracted from your age
        // 18.03.1990 > 14.03.1990, so your age is 23, not 24
        if (birthday > today.AddYears(-age)) age--;
       
        //Printing how old you are now
        //23
        Console.WriteLine("You are {0} years old today.",age);
       
        //Printing your age after 10 years
        //33
        Console.WriteLine("You will be {0} years old in 10 years", age+10);
    }
}