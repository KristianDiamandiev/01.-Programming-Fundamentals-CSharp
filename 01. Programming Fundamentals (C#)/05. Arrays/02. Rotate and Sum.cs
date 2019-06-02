using System;
using System.Linq;

class Program
{
    static void ReverseString (int[] a)
    {
        int[] b = new int[a.Length];
        b[0] = a[a.Length - 1];
        for (int i = 0; i < a.Length - 1; i++)
            b[i+1] = a[i];
        for (int i = 0; i < a.Length; i++)
          a[i] = b[i];
    }

    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberOfReverses = int.Parse(Console.ReadLine());
        int[] sums = new int[nums.Length];
        while (numberOfReverses > 0)
        {
            ReverseString(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                sums[i] = sums[i] + nums[i];
            }
            numberOfReverses--;
        }
        Console.WriteLine(String.Join(" ", sums));
    }
}

