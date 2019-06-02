using System;

class Program
{
    static void Main()
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        object obj = (string)(str1 + " " + str2);
        Console.WriteLine(obj);
    }
}

