using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        BigInteger num = 1;
        for (long i = 1; i <= a; i++)
            num = num * i;
        Console.WriteLine(num);
    }
}

