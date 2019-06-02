using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main()
    {
        string[] firstString = Console.ReadLine().Split(' ');
        string[] secondString = Console.ReadLine().Split(' ');
        int rightCount = 0;
        int leftCount = 0;
        while (rightCount < firstString.Length && rightCount < secondString.Length)
        {
            if (firstString[firstString.Length - rightCount - 1] == secondString[secondString.Length - rightCount - 1])
            {
                rightCount++;
            }
            else break;
        }

        while (leftCount < firstString.Length && leftCount < secondString.Length)
        {
            if (firstString[leftCount] == secondString[leftCount])
            {
                leftCount++;
            }
            else break;
        }

        if (rightCount > leftCount)
        {
            Console.WriteLine(rightCount);
        }
        else
        {
            Console.WriteLine(leftCount);
        }
    }
}

