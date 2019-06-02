using System;

class Program
{
    static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static void Main()
    {
        string firstName = Console.ReadLine();
        PrintName(firstName);
    }
}

