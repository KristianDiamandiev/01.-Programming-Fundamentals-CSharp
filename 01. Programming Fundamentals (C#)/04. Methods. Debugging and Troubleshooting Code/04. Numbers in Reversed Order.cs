using System;

class Program
{
    static void ReverseNumber(string a)
    {
        for(int i = a.Length-1; i >= 0; i--)
        {
            Console.Write(a[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string num = Console.ReadLine();
        ReverseNumber(num);
    }
}

