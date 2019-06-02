using System;

class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        if (Math.Abs(num1 - num2)  < 0.000001)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}


