using System;

class Program
{
    static double TriangleArea(double a, double ha)
    {
        return a * ha / 2;
    }

    static double SquareArea(double a)
    {
        return a * a;
    }

    static double RectangleArea(double a, double b)
    {
        return a * b;
    }

    static double CircleArea(double r)
    {
        return Math.PI * r * r;
    }

    static void Main()
    {
        string figure = Console.ReadLine();
        if (figure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            Console.WriteLine($"{TriangleArea(a,ha):F2}");
        }
        else if (figure == "square")
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"{SquareArea(a):F2}");
        }
        else if (figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{RectangleArea(a, b):F2}");
        }
        else if (figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CircleArea(r):F2}");
        }
    }
}

