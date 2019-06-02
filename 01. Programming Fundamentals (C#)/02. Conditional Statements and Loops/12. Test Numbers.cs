using System;

class Program
{
    static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var maxSum = int.Parse(Console.ReadLine());
        int sum = 0;
        int combinationCounter = 0;
        bool breakFlag = false;
        for (int i = num1; i >= 1; i--)
        {
            for (int j = 1; j <= num2; j++)
            {
                sum = sum + 3 * (i * j);
                combinationCounter++;
                if (sum >= maxSum)
                {
                    breakFlag = true;
                    break;
                }
            }
            if (breakFlag == true)
                break;
        }
        Console.WriteLine("{0} combinations", combinationCounter);
        if (sum >= maxSum)
            Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
        else
            Console.WriteLine("Sum: {0}", sum);
    }
}

