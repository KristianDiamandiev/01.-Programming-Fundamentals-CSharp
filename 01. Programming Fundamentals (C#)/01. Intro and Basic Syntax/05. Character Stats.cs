using System;

class Program
{
    static void Main()
    {
        var name = Console.ReadLine();
        var currHp = int.Parse(Console.ReadLine());
        var maxHp = int.Parse(Console.ReadLine());
        var currEn = int.Parse(Console.ReadLine());
        var maxEn = int.Parse(Console.ReadLine());
        Console.WriteLine("Name: {0}", name);
        Console.Write("Health: |");
        Console.Write(new string('|',currHp));
        Console.Write(new string('.', maxHp-currHp));
        Console.WriteLine("|");
        Console.Write("Energy: |");
        Console.Write(new string('|', currEn));
        Console.Write(new string('.', maxEn - currEn));
        Console.WriteLine("|");
    }
}