using System;
using System.Collections.Generic;

    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
           
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0} : ", i+1);
                nums.Add(int.Parse(Console.ReadLine()));
            }
            
            nums.Sort();
            //Option 2 for sorting:
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            int help = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = help;
            //        }
            //    }
            //}

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }

