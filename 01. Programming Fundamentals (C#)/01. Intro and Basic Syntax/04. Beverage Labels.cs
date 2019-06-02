using System;

class Program
{
    static void Main()
    {
        var drink = Console.ReadLine();
        var mil = double.Parse(Console.ReadLine());
        var kcal = double.Parse(Console.ReadLine());
        var g = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}ml {1}:", mil, drink);
        Console.WriteLine("{0}kcal, {1}g sugars", mil*kcal/100, g*mil/100);
    }
}

