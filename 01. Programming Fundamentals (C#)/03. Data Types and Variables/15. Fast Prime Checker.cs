using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        Console.WriteLine("2 -> True");
        Console.WriteLine("3 -> True");
        for (int i = 4; i <= num; i++)
        {
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime}");
            isPrime = true;
        }
    }
}

