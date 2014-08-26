using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1..999] : ");
        int num = int.Parse(Console.ReadLine());
        if (num < 1 || num > 999)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            string name = string.Empty;
            if (num >= 100)
            {
                if (num % 100 == 0)
                {
                    name = "hundred";
                }
                else
                {
                    name = "hundred and ";
                }
                switch (num/100)
                {
                    case 1: name = "one " + name;
                        break;
                    case 2: name = "two " + name;
                        break;
                    case 3: name = "three " + name;
                        break;
                    case 4: name = "four " + name;
                        break;
                    case 5: name = "five " + name;
                        break;
                    case 6: name = "six " + name;
                        break;
                    case 7: name = "seven " + name;
                        break;
                    case 8: name = "eight " + name;
                        break;
                    case 9: name = "nine " + name;
                        break;
                    default:
                        break;
                }
                num %= 100;
            }
            if (num >= 20)
            {
                switch (num/10)
                {
                    case 2: name += "twenty";
                        break;
                    case 3: name += "thirty";
                        break;
                    case 4: name += "fourty";
                        break;
                    case 5: name += "fifty";
                        break;
                    case 6: name += "sixty";
                        break;
                    case 7: name += "seventy";
                        break;
                    case 8: name += "eighty";
                        break;
                    case 9: name += "ninety";
                        break;
                    default:
                        break;
                }
                if (num % 10 != 0)
                {
                    name += " ";
                }
                num %= 10;
            }
            switch (num)
            {
                case 0: name = (name == String.Empty)? "zero" : name;
                    break;
                case 1: name += "one";
                    break;
                case 2: name += "two";
                    break;
                case 3: name += "three";
                    break;
                case 4: name += "four";
                    break;
                case 5: name += "five";
                    break;
                case 6: name += "six";
                    break;
                case 7: name += "seven";
                    break;
                case 8: name += "eight";
                    break;
                case 9: name += "nine";
                    break;
                case 10: name += "ten";
                    break;
                case 11: name += "eleven";
                    break;
                case 12: name += "twelve";
                    break;
                case 13: name += "thirteen";
                    break;
                case 14: name += "fourteen";
                    break;
                case 15: name += "fifteen";
                    break;
                case 16: name += "sixteen";
                    break;
                case 17: name += "seventeen";
                    break;
                case 18: name += "eighteen";
                    break;
                case 19: name += "nineteen";
                    break;
                case 20: name += "twenty";
                    break;
                
                default:
                    break;
            }
            Console.WriteLine(name);
        }
    }
}

