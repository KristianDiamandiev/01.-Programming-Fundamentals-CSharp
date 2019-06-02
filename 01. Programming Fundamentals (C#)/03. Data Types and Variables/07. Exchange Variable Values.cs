using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Before:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("After:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

