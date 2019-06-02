using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        float meters = float.Parse(Console.ReadLine());
        float hours = int.Parse(Console.ReadLine());
        float minutes = int.Parse(Console.ReadLine());
        float seconds = int.Parse(Console.ReadLine());
        float timeInSeconds = seconds + minutes * 60 + hours * 60 * 60;
        float timeInHours = hours + minutes / 60 + (seconds / 60) / 60;
        Console.WriteLine(meters / timeInSeconds);
        Console.WriteLine((meters / 1000) / timeInHours);
        Console.WriteLine((meters / 1609) / timeInHours);
    }
}

