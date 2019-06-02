using System;

class Program
{
    static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var searchedSum = int.Parse(Console.ReadLine());
        int magicNum1 = 0, magicNum2 = 0, combinationCounter = 0;
        for (int i = num1; i <= num2; i++)
            for(int j = num1; j <= num2; j++)
            {
                if (i + j == searchedSum)
                {
                    magicNum1 = i;
                    magicNum2 = j;
                }
                combinationCounter++;
            }
        if (magicNum1 == 0)
            Console.WriteLine("{0} combinations - neither equals {1}", combinationCounter, searchedSum);
        else
            Console.WriteLine("Number found! {0} + {1} = {2}", magicNum1, magicNum2, searchedSum);
    }
}

