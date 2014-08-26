using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string left = String.Empty;
        string right = String.Empty;
        if ((n / 2) % 2 == 0)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    left = left + ".";
                }
                for (int j = n / 2 - i - 1; j < n / 2; j++)
                {
                    if ((i + j) % 2 == 0) left = left + " ";
                    else left = left + "/";
                }
                for (int j = n / 2 + 1; j < n - i; j++)
                {
                    right = right + ".";
                }
                for (int j = n - i; j <= n; j++)
                {
                    if ((i + j) % 2 == 0) right = "\\" + right;
                    else right = " " + right;
                }
                Console.WriteLine(left + right);
                left = String.Empty;
                right = String.Empty;
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    left = left + ".";
                }
                for (int j = n / 2 - i - 1; j < n / 2; j++)
                {
                    if ((i + j) % 2 == 0) left = left + " ";
                    else left = left + "\\";
                }
                for (int j = n / 2 + 1; j < n - i; j++)
                {
                    right = right + ".";
                }
                for (int j = n - i; j <= n; j++)
                {
                    if ((i + j) % 2 == 0) right = "/" + right;
                    else right = " " + right;
                }
                Console.WriteLine(left + right);
                left = String.Empty;
                right = String.Empty;
            }
        }
        else
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    left = left + ".";
                }
                for (int j = n / 2 - i - 1; j < n / 2; j++)
                {
                    if ((i + j) % 2 != 0) left = left + " ";
                    else left = left + "/";
                }
                for (int j = n / 2 + 1; j < n - i; j++)
                {
                    right = right + ".";
                }
                for (int j = n - i; j <= n; j++)
                {
                    if ((i + j) % 2 == 0) right = "\\" + right;
                    else right = " " + right;
                }
                Console.WriteLine(left + right);
                left = String.Empty;
                right = String.Empty;
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    left = left + ".";
                }
                for (int j = n / 2 - i - 1; j < n / 2; j++)
                {
                    if ((i + j) % 2 != 0) left = left + " ";
                    else left = left + "\\";
                }
                for (int j = n / 2 + 1; j < n - i; j++)
                {
                    right = right + ".";
                }
                for (int j = n - i; j <= n; j++)
                {
                    if ((i + j) % 2 == 0) right = "/" + right;
                    else right = " " + right;
                }
                Console.WriteLine(left + right);
                left = String.Empty;
                right = String.Empty;
            }
        }
    }
}

