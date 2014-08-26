using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    Console.Write("You chose int!\nEnter an integer number:");
                    int num = int.Parse(Console.ReadLine());
                    num += 1;
                    Console.WriteLine(num);
                    break;
                }
            case 2:
                {
                    Console.Write("You chose double!\nEnter a double number:");
                    double num = double.Parse(Console.ReadLine());
                    num += 1;
                    Console.WriteLine(num);
                    break;
                }
            case 3:
                {
                    Console.Write("You chose string!\nEnter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                }
            default: Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
