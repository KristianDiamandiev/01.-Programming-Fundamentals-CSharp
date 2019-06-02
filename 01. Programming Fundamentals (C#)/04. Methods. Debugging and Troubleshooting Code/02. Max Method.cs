using System;

class Program
{
    static int GetMax(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int max = GetMax(num1, num2);
        if (GetMax(num2, num3) > max)
            max = num3;
        Console.WriteLine(max);
    }
}

