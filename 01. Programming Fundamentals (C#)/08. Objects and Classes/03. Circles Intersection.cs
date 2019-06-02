using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }

    static Circle CreateCircle()
    {
        Circle newCircle = new Circle();
        double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        newCircle.X = input[0];
        newCircle.Y = input[1];
        newCircle.Radius = input[2];
        return newCircle;
    }

    static void Main()
    {
        Circle c1 = new Circle(), c2 = new Circle();
        c1 = CreateCircle();
        c2 = CreateCircle();
        double distance = Math.Sqrt((c1.X - c2.X) * (c1.X - c2.X) + (c1.Y - c2.Y) * (c1.Y - c2.Y));
        if (distance <= c1.Radius + c2.Radius)
        {
            Console.WriteLine("Yes");
        }
        else
            Console.WriteLine("No");
    }
}

