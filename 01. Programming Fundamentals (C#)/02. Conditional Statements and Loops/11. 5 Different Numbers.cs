using System;

class Program
{
    static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        if (num2 - 4 < num1)
            Console.WriteLine("No");
        else
            for (int i = num1; i <= num2-4; i++)
                for (int j = i+1; j <= num2 - 3; j++)
                    for (int k = j+1; k <= num2 - 2; k++)
                        for (int l = k+1; l <= num2 - 1; l++)
                            for (int m = l+1; m <= num2 - 0; m++)
                                Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, l, m);
    }
}

