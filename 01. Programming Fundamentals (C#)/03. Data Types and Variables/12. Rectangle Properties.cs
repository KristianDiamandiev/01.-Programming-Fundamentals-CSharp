using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine(2 * width + 2 * height);
        Console.WriteLine(width * height);
        Console.WriteLine(Math.Sqrt(width*width + height*height));
    }
}

