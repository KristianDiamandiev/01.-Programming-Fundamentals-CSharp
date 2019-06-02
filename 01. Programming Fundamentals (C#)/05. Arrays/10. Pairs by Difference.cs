using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i] + difference || nums[j] == nums[i] - difference)
                    counter++;
            }
        Console.WriteLine(counter);
    }
}

