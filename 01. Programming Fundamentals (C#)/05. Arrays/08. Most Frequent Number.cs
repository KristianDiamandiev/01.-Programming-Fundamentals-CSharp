using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 1;
        int maxCounter = 0;
        int[] values = new int[nums.Length];
        int maxValue = nums[0];
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxValue = nums[i];
                    }
                }
            }
            counter = 1;
        }
        Console.WriteLine(maxValue);
    }
}

