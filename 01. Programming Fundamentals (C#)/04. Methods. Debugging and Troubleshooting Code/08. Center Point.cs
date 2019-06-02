using System;

class Program
{
    static double DistanceBetweenCenterAndAPoint(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double distance1 = DistanceBetweenCenterAndAPoint(x1, y1);
        double distance2 = DistanceBetweenCenterAndAPoint(x2, y2);
        if (distance1 <= distance2)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}

