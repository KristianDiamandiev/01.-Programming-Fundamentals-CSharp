using System;

class Program
{
    static double DistanceBetweenCenterAndAPoint(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    static double DistanceBetween2Points(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
    }

    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());
        double lengthOfLine1 = DistanceBetween2Points(x1, y1, x2, y2);
        double lengthOfLine2 = DistanceBetween2Points(x3, y3, x4, y4);
        if (lengthOfLine1 >= lengthOfLine2)
        {
            if (DistanceBetweenCenterAndAPoint(x1, y1) <= DistanceBetweenCenterAndAPoint(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        else
        {
            if (DistanceBetweenCenterAndAPoint(x3, y3) <= DistanceBetweenCenterAndAPoint(x4, y4))
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }
}

