using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (nums.Length == 1)
            Console.WriteLine(0);
        else
        {
            int testSum = 0;
            int saveSeparator = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                testSum = testSum + nums[i];
            }
            if (testSum == 0)
            {
                Console.WriteLine(0);
                saveSeparator = 0;
            }
            else
            {
                int separator = 1;
                while (separator != nums.Length)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    for (int i = 0; i < separator; i++)
                    {
                        leftSum = leftSum + nums[i];
                    }
                    for (int i = separator + 1; i < nums.Length; i++)
                    {
                        rightSum = rightSum + nums[i];
                    }
                    if (leftSum == rightSum)
                        saveSeparator = separator;
                    separator++;
                }
            }
            if (saveSeparator == -1)
                Console.WriteLine("no");
            else if (saveSeparator > 0)
                Console.WriteLine(saveSeparator);
        }
    }
}

