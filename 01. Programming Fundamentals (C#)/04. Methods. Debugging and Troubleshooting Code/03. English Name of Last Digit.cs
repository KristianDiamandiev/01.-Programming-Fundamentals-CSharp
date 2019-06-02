using System;

class Program
{
    static void LastDigitName(int a)
    {
        string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        Console.WriteLine(digitNames[a]);
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        if (num < 0)
            num = -num;
        LastDigitName((int)(num % 10));
    }
}

